using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK
{

        class information
        {
            public string name_sname;
            public string id;
            public string mail;
            public string telno;
            public string cv_path;

            public information(string name_sname, string id, string mail, string telno, string cv_path)
            {
                this.name_sname = name_sname;
                this.id = id;
                this.mail = mail;
                this.telno = telno;
                this.cv_path = cv_path;
            }

            public string Name_sname
            {

                set
                {
                    name_sname = value;
                    SaveToFile(name_sname);

                }
            }
            public string Id
            {

                set
                {
                    if (value.Length == 11)

                    {
                        id = value;
                        SaveToFile(id);
                    }

                }

            }
            public string Mail
            {
                set
                {
                    mail = value;
                    SaveToFile(mail);
                }
            }
            public string Telno
            {
                set
                {
                    telno = value;
                    SaveToFile(telno);
                }
            }
            public string Cv_path
            {
                set
                {
                    try
                    {
                        cv_path = value;
                        SaveToFile(cv_path);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya yolu bulunamiyor" + ex.Message);

                    }


                }
            }

            public void SaveToFile(string data)
            {
              //  string fileName = meslek + "Bilgiler.txt";//bunu nasıl düzeltebilrim ??????????????????

                string filePath = @"C:\Users\Beyza\Desktop\IK\cv.txt"; //Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(data);

                }
            }


        }
    }
