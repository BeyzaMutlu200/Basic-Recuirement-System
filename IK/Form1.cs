using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                textBoxList = new List<TextBox>();

            // Tasarım arayüzü üzerinden eklenen TextBox'ları List'e ekle
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    textBoxList.Add((TextBox)control);
                }
            }
        }
        private List<TextBox> textBoxList;


       public void button1_Click(object sender, EventArgs e)
        {
            
            information IN = new information("", "", "", "", "");

            // Her bir TextBox'ın içeriğini topla
            IN.Name_sname = textBox1.Text;
            IN.Id = textBox2.Text;
            IN.Mail = textBox3.Text;
            IN.Telno = textBox4.Text;
            // Seçilen meslek türünü alın
            string meslek = comboBox1.SelectedItem.ToString();

            // Alınan bilgileri ilgili dosyaya kaydedin





       //     SaveToFile(meslek);      // birde burasııııı



            // Toplanan verileri SaveToFile metoduna geçir
            var result = true;
            if (result)
            {
                try
                {
                    // Her bir TextBox için kontrolü gerçekleştir
                    foreach (var textBox in textBoxList)
                    {
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            throw new ArgumentException("doldurlmayan alan/alanlar mevcut !");
                        }

                        // Diğer işlemleri buraya ekleyebilirsiniz
                        Console.WriteLine("Girilen Metin: " + textBox.Text);

                    }
                    if (string.IsNullOrWhiteSpace(label6.Text) || !label6.Text.ToLower().EndsWith(".pdf"))
                    {
                        throw new ArgumentException("Geçerli bir PDF dosyası seçilmelidir!");
                    }
                    if(string.IsNullOrEmpty(comboBox1.Text))
                    { throw new ArgumentException("Lütfen meslek seçiniz!"); }
                }
                catch (ArgumentException ex)
                {
                    // TextBox boşsa burası çalışır
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //pdfdosyayolu için nasıl ekleme yapabilrim exception hatasını ?
            }
            //     MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirildi ", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            // ekleyince throw mesajından sonra doğru 
        }
        public void button3_Click(object sender, EventArgs e)

        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select File";
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "PDF Dosyaları|*.pdf|Tüm Dosyalar|*.*";
                openFileDialog.FilterIndex = 5;

                if (openFileDialog.ShowDialog() == DialogResult.OK || openFileDialog.FileName != "")
                {
                    // Seçilen PDF dosyasının yolu
                    string pdfDosyaYolu = openFileDialog.FileName;

                    // PDF dosyasının içeriğini okuma işlemleri burada gerçekleştirilebilir

                    // Örneğin, PDF içeriğini bir TextBox'a yazdırmak

                    label6.Text = pdfDosyaYolu; //DOSYA YOLUNU DOĞRU ALIYORUM AMA DOSYAYA SEÇ YAZISIYLA BİRLİKTE KAYIT İŞLEMİ YAPILIYOR BUNU İSTEMİYORUM NASIL DÜZELTEBİLİRİM. 
                } 
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
