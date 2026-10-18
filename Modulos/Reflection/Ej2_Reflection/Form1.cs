using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System.Reflection;
using System.Text;

namespace Ej2_Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetectarClases_Click(object sender, EventArgs e)
        {
            Assembly assem;
            string dllRuta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ej2_Clases.dll");
            assem = Assembly.LoadFrom(dllRuta);
            Type[] tipos = assem.GetTypes();
            string tiposTexto = "";
            foreach (Type t in tipos)
            {
                tiposTexto += $"{t.Name}\n";
            }
            MessageBox.Show(tiposTexto, "Listado de clases", MessageBoxButtons.OK);
        }

        private void btnDetectarMetodos_Click(object sender, EventArgs e)
        {
            Assembly assem = Assembly.Load("Ej2_Clases");
            Type clase = assem.GetType("Ej2_Clases.Automovil");
            MemberInfo[] miembros = clase.GetMembers(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            string miembrosTexto = "";
            foreach (MemberInfo m in miembros)
            {
                miembrosTexto += $"{m.Name}\n";
            }
            MessageBox.Show(miembrosTexto, "Listado de métodos", MessageBoxButtons.OK);
        }

        private void btnDetectarParametros_Click(object sender, EventArgs e)
        {
            Assembly assem = Assembly.Load("Ej2_Clases");
            Type clase = assem.GetType("Ej2_Clases.Automovil");
            MethodInfo metodo = clase.GetMethod("Acelerar");
            ParameterInfo[] parametros = metodo.GetParameters();
            string parametrosTexto = "";
            foreach (ParameterInfo p in parametros)
            {
                parametrosTexto += $"{p.Name} ({p.ParameterType.Name})\n";
            }
            MessageBox.Show(parametrosTexto, "Listado de métodos", MessageBoxButtons.OK);
        }

        private void btnCrearClase_Click(object sender, EventArgs e)
        {
            string codigo = @"
                using System;
                namespace Prueba
                {
                    public class ClaseNueva
                    {
                        public string Saludar() => ""Hola mundo"";
                    }
                }
            ";
            SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(codigo);
            string assemblyPath = Path.GetDirectoryName(typeof(object).Assembly.Location);
            var referencias = new MetadataReference[]
            {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Runtime.dll"))
            };

            CSharpCompilation compilation = CSharpCompilation.Create(
                "AssemTemporal_" + Guid.NewGuid().ToString("N"),
                new[] { syntaxTree },
                referencias,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
            );

            using (var ms = new MemoryStream())
            {
                EmitResult resultado = compilation.Emit(ms);

                if (!resultado.Success)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (Diagnostic diagnostic in resultado.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error))
                    {
                        sb.AppendLine($"Error {diagnostic.Id}: {diagnostic.GetMessage()}");
                    }
                    MessageBox.Show(sb.ToString(), "Error creando clase en tiempo de ejecución");
                }
                else
                {
                    ms.Seek(0, SeekOrigin.Begin);
                    Assembly assem = Assembly.Load(ms.ToArray());

                    object instancia = assem.CreateInstance("Prueba.ClaseNueva");
                    Type tipo = assem.GetType("Prueba.ClaseNueva");
                    MethodInfo metodo = tipo.GetMethod("Saludar");

                    string saludo = metodo.Invoke(instancia, null).ToString();
                    MessageBox.Show(saludo, "Instanciando clase en tiempo de ejecución");
                }
            }
        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            Assembly assem = Assembly.Load("Ej2_Clases");
            Type clase = assem.GetType("Ej2_Clases.Automovil");
            object instancia = assem.CreateInstance("Ej2_Clases.Automovil");

            clase.GetProperty("Patente").SetValue(instancia, "AA222BB");
            clase.GetProperty("Marca").SetValue(instancia, "Toyota");
            clase.GetMethod("Acelerar").Invoke(instancia, new object[] { 15 });

            string datosObjeto = "";
            PropertyInfo[] propiedades = clase.GetProperties();
            foreach (PropertyInfo p in propiedades)
            {
                object valor = p.GetValue(instancia, null);
                datosObjeto += $"{p.Name}: {valor}\n";
            }
            MessageBox.Show(datosObjeto, "Instanciando en tiempo de ejecución", MessageBoxButtons.OK);
        }
    }
}
