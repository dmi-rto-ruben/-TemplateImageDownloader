using System.Diagnostics;
using System.IO;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TemplateDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void addFolder(string folder)
        {
            // Agregar todas las carpetas al ListBox
            string[] carpetas = Directory.GetDirectories(folder);
            foreach (string carpeta in carpetas)
            {
                listBox1.Items.Add("[Directorio] " + folder + "\\" + Path.GetFileName(carpeta) + " #");

                this.addFolder(carpeta);
            }

            // Agregar todos los archivos al ListBox
            string[] archivos = Directory.GetFiles(folder);
            foreach (string archivo in archivos)
            {
                listBox1.Items.Add("[archivo] " + folder + "\\" + Path.GetFileName(archivo));
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var dialogoDirectorio = new FolderBrowserDialog())
            {
                // Mostrar el cuadro de diálogo para seleccionar un directorio
                DialogResult resultado = dialogoDirectorio.ShowDialog();

                // Verificar si el usuario seleccionó un directorio

                if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(dialogoDirectorio.SelectedPath))
                {
                    string directorioSeleccionado = dialogoDirectorio.SelectedPath;

                    txtFolderBase.Text = directorioSeleccionado;


                    listBox1.Items.Clear();

                    this.addFolder(directorioSeleccionado);
                }
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            string directorio = txtFolderBase.Text;
            string url = txtUrl.Text;
            // Crear una lista para almacenar los elementos del ListBox
            List<string> itemsListBox = new List<string>();

            // Iterar sobre todos los elementos del ListBox y agregarlos a la lista
            foreach (string item in listBox1.Items)
            {
                if (item.Contains("[archivo]"))
                {
                    int index = item.IndexOf(directorio);
                    if (index != -1)
                    {
                        // Obtener la parte de la cadena después de "directorio"
                        string restoCadena = item.Substring(index + directorio.Length + 1);
                        itemsListBox.Add(restoCadena);
                    }


                }

            }

            // Convertir la lista a un arreglo de cadenas
            string[] arregloCadenas = itemsListBox.ToArray();

            listBox1.Items.Clear();
            string newUrl;
            string newImageFile;

            // Iterar sobre todos los elementos del ListBox
            foreach (string item in arregloCadenas)
            {
                newUrl = url + "/" + item.Replace("\\", "/");

                newImageFile = directorio + "\\" + item;


                try
                {
                    WebRequest solicitud = WebRequest.Create(newUrl);

                    using (WebResponse respuesta = solicitud.GetResponse())
                    {
                        using (Stream flujoArchivo = File.Create(newImageFile))
                        {
                            using (Stream flujoRespuesta = respuesta.GetResponseStream())
                            {
                                flujoRespuesta.CopyTo(flujoArchivo);
                            }
                        }
                    }
                }
                catch (Exception e2)
                {
                    Console.WriteLine("{0} Excepcción capturada.", e2);
                }

                // Verificar si el archivo existe en la ubicación especificada por "url"
                if (File.Exists(newImageFile))
                {
                    // Copiar el archivo de la ubicación de "url" a la ubicación de "file"
                    //File.Copy(url, newImageFile, true); // Utiliza true para sobrescribir el archivo si ya existe en la ubicación de destino
                    listBox1.Items.Add(" -> [archivo] " + newImageFile);
                }
                else
                {
                    // Mostrar un mensaje de error si el archivo no existe en la ubicación de "url"
                    listBox1.Items.Add("No existe: " + newUrl);
                }


            }




        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = txtFolderBase.Text;

            // Verificar si el directorio existe antes de abrirlo
            if (Directory.Exists(rutaDirectorio))
            {
                // Abrir el explorador de archivos en la ruta del directorio
                Process.Start("explorer.exe", rutaDirectorio);
            }
            else
            {
                // Mostrar un mensaje de error si la ruta del directorio no es válida
                MessageBox.Show("La ruta del directorio no es válida o está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = listBox1.SelectedItem.ToString();

            if (path.Contains("[archivo]"))
            {
                int index = path.IndexOf(']');
                if (index != -1)
                {
                    // Obtener la parte de la cadena después de "directorio"
                    string restoCadena = (path.Substring(index + 1)).Trim();


                    lblImagen.Text = ("[" + restoCadena + "]").Replace(txtFolderBase.Text, "");
                    pictureBox1.Image = Image.FromFile(restoCadena);
                }


            }


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSyncUrl_Click(object sender, EventArgs e)
        {
            string rutaDirectorioCompleta = txtFolderBase.Text.Trim();
            int index = rutaDirectorioCompleta.LastIndexOf("\\");

            // Obtener el nombre del último directorio en la ruta
            string ultimoDirectorio = rutaDirectorioCompleta.Substring(index + 1);

            string url = txtUrl.Text.Trim();

            index = url.IndexOf(ultimoDirectorio);

            txtUrl.Text = url.Substring(0, index + ultimoDirectorio.Length);

            MessageBox.Show("Se sincronizo correctamente el directorio y la URL: " + ultimoDirectorio);
        }

    }
}
