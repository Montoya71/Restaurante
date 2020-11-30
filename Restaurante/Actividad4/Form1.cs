using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Tortas1.Checked == true)
            {
                check_Tortas2.Enabled = false;
                check_Tortas3.Enabled = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Tortas3.Checked == true)
            {
                check_Tortas2.Enabled = false;
                check_Tortas1.Enabled = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Tortas2.Checked == true)
            {
                check_Tortas1.Enabled = false;
                check_Tortas3.Enabled = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(check_Tortas.Checked == true)
            {
                //Hambuerguesa
                check_Hamburguesa.Enabled = false;
                check_Hamburguesa1.Enabled = false;
                check_Hamburguesa2.Enabled = false;
                check_Hamburguesa3.Enabled = false;
                //Hotdog
                check_Hotdog.Enabled = false;
                check_Hotdog1.Enabled = false;
                check_Hotdog2.Enabled = false;
                check_Hotdog3.Enabled = false;
                //Tacos
                check_Tacos.Enabled = false;
                check_Tacos1.Enabled = false;
                check_Tacos2.Enabled = false;
                check_Tacos3.Enabled = false;

                //Activar
                check_Tortas1.Enabled = true;
                check_Tortas2.Enabled = true;
                check_Tortas3.Enabled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Tortas
            check_Tortas1.Enabled = false;
            check_Tortas2.Enabled = false;
            check_Tortas3.Enabled = false;
            //Hambuerguesa
            check_Hamburguesa1.Enabled = false;
            check_Hamburguesa2.Enabled = false;
            check_Hamburguesa3.Enabled = false;
            check_Hamburguesa4.Enabled = false;
            check_Hamburguesa5.Enabled = false;
            check_Hamburguesa6.Enabled = false;
            check_Hamburguesa7.Enabled = false;
            check_Hamburguesa8.Enabled = false;
            check_Hamburguesa9.Enabled = false;
            check_Hamburguesa10.Enabled = false;
            check_Hamburguesa11.Enabled = false;
            check_Hamburguesa12.Enabled = false;
            //Hotdog
            check_Hotdog1.Enabled = false;
            check_Hotdog2.Enabled = false;
            check_Hotdog3.Enabled = false;
            check_Hotdog4.Enabled = false;
            check_Hotdog5.Enabled = false;
            check_Hotdog6.Enabled = false;
            check_Hotdog7.Enabled = false;
            check_Hotdog8.Enabled = false;
            check_Hotdog9.Enabled = false;
            check_Hotdog10.Enabled = false;
            check_Hotdog11.Enabled = false;
            check_Hotdog12.Enabled = false;
            check_Hotdog13.Enabled = false;
            //Tacos
            check_Tacos1.Enabled = false;
            check_Tacos2.Enabled = false;
            check_Tacos3.Enabled = false;
            check_Tacos4.Enabled = false;
            check_Tacos5.Enabled = false;
            check_Tacos6.Enabled = false;
            check_Tacos7.Enabled = false;
            check_Tacos8.Enabled = false;
            check_Tacos9.Enabled = false;
            check_Tacos10.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (check_Tacos.Checked == true)
            {
                //Hambuerguesa
                check_Hamburguesa.Enabled = false;
                check_Hamburguesa1.Enabled = false;
                check_Hamburguesa2.Enabled = false;
                check_Hamburguesa3.Enabled = false;
                check_Hamburguesa4.Enabled = false;
                check_Hamburguesa5.Enabled = false;
                check_Hamburguesa6.Enabled = false;
                check_Hamburguesa7.Enabled = false;
                check_Hamburguesa8.Enabled = false;
                check_Hamburguesa9.Enabled = false;
                check_Hamburguesa10.Enabled = false;
                check_Hamburguesa11.Enabled = false;
                check_Hamburguesa12.Enabled = false;

                //Hotdog
                check_Hotdog.Enabled = false;
                check_Hotdog1.Enabled = false;
                check_Hotdog2.Enabled = false;
                check_Hotdog3.Enabled = false;
                check_Hotdog4.Enabled = false;
                check_Hotdog5.Enabled = false;
                check_Hotdog6.Enabled = false;
                check_Hotdog7.Enabled = false;
                check_Hotdog8.Enabled = false;
                check_Hotdog9.Enabled = false;
                check_Hotdog10.Enabled = false;
                check_Hotdog11.Enabled = false;
                check_Hotdog12.Enabled = false;
                check_Hotdog13.Enabled = false;

                //Tortas
                check_Tortas.Enabled = false;
                check_Tortas1.Enabled = false;
                check_Tortas2.Enabled = false;
                check_Tortas3.Enabled = false;

                //Tacos
                check_Tacos4.Enabled = false;
                check_Tacos5.Enabled = false;
                check_Tacos6.Enabled = false;
                check_Tacos7.Enabled = false;
                check_Tacos8.Enabled = false;
                check_Tacos9.Enabled = false;
                check_Tacos10.Enabled = false;

                //Activar
                check_Tacos1.Enabled = true;
                check_Tacos2.Enabled = true;
                check_Tacos3.Enabled = true;
            } 
        }
        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            //Hotdog
            check_Hotdog.Enabled = true;
            check_Hotdog1.Enabled = false;
            check_Hotdog2.Enabled = false;
            check_Hotdog3.Enabled = false;
            check_Hotdog4.Enabled = false;
            check_Hotdog5.Enabled = false;
            check_Hotdog6.Enabled = false;
            check_Hotdog7.Enabled = false;
            check_Hotdog8.Enabled = false;
            check_Hotdog9.Enabled = false;
            check_Hotdog10.Enabled = false;
            check_Hotdog11.Enabled = false;
            check_Hotdog12.Enabled = false;
            check_Hotdog13.Enabled = false;

            //Tacos
            check_Tacos.Enabled = true;
            check_Tacos1.Enabled = false;
            check_Tacos2.Enabled = false;
            check_Tacos3.Enabled = false;
            check_Tacos4.Enabled = false;
            check_Tacos5.Enabled = false;
            check_Tacos6.Enabled = false;
            check_Tacos7.Enabled = false;
            check_Tacos8.Enabled = false;
            check_Tacos9.Enabled = false;
            check_Tacos10.Enabled = false;

            //Tortas
            check_Tortas.Enabled = true;
            check_Tortas1.Enabled = false;
            check_Tortas2.Enabled = false;
            check_Tortas3.Enabled = false;
            //Hamgurguesas
            check_Hamburguesa.Enabled = true;
            check_Hamburguesa1.Enabled = false;
            check_Hamburguesa2.Enabled = false;
            check_Hamburguesa3.Enabled = false;
            check_Hamburguesa4.Enabled = false;
            check_Hamburguesa5.Enabled = false;
            check_Hamburguesa6.Enabled = false;
            check_Hamburguesa7.Enabled = false;
            check_Hamburguesa8.Enabled = false;
            check_Hamburguesa9.Enabled = false;
            check_Hamburguesa10.Enabled = false;
            check_Hamburguesa11.Enabled = false; 
            check_Hamburguesa12.Enabled = false;

        }

        private void check_Tacos1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Tacos1.Checked == true)
            {
                check_Tacos2.Enabled = false;
                check_Tacos3.Enabled = false;

                //Activar
                check_Tacos4.Enabled = true;
                check_Tacos5.Enabled = true;
                check_Tacos6.Enabled = true;
                check_Tacos7.Enabled = true;
                check_Tacos8.Enabled = true;
                check_Tacos9.Enabled = true;
                check_Tacos10.Enabled = true;
            }
        }

        private void check_Hamburguesa_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Hamburguesa.Checked == true)
            {
                //Tortas
                check_Tortas.Enabled = false;
                check_Tortas1.Enabled = false;
                check_Tortas2.Enabled = false;
                check_Tortas3.Enabled = false;

                //Hotdog
                check_Hotdog.Enabled = false;
                check_Hotdog1.Enabled = false;
                check_Hotdog2.Enabled = false;
                check_Hotdog3.Enabled = false;
                check_Hotdog4.Enabled = false;
                check_Hotdog5.Enabled = false;
                check_Hotdog6.Enabled = false;
                check_Hotdog7.Enabled = false;
                check_Hotdog8.Enabled = false;
                check_Hotdog9.Enabled = false;
                check_Hotdog10.Enabled = false;
                check_Hotdog11.Enabled = false;
                check_Hotdog12.Enabled = false;
                check_Hotdog13.Enabled = false;

                //Tacos
                check_Tacos.Enabled = false;
                check_Tacos1.Enabled = false;
                check_Tacos2.Enabled = false;
                check_Tacos3.Enabled = false;
                check_Tacos4.Enabled = false;
                check_Tacos5.Enabled = false;
                check_Tacos6.Enabled = false;
                check_Tacos7.Enabled = false;
                check_Tacos8.Enabled = false;
                check_Tacos9.Enabled = false;
                check_Tacos10.Enabled = false;

                //Hamburguesa
                check_Hamburguesa4.Enabled = false;
                check_Hamburguesa5.Enabled = false;
                check_Hamburguesa6.Enabled = false;
                check_Hamburguesa7.Enabled = false;
                check_Hamburguesa8.Enabled = false;
                check_Hamburguesa9.Enabled = false;
                check_Hamburguesa10.Enabled = false;
                check_Hamburguesa11.Enabled = false;
                check_Hamburguesa12.Enabled = false;

                //Activar
                check_Hamburguesa1.Enabled = true;
                check_Hamburguesa2.Enabled = true;
                check_Hamburguesa3.Enabled = true;
            }
        }

        private void check_Hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Hotdog.Checked == true)
            {
                //Tortas
                check_Tortas.Enabled = false;
                check_Tortas1.Enabled = false;
                check_Tortas2.Enabled = false;
                check_Tortas3.Enabled = false;

                //Hambuerguesa
                check_Hamburguesa.Enabled = false;
                check_Hamburguesa1.Enabled = false;
                check_Hamburguesa2.Enabled = false;
                check_Hamburguesa3.Enabled = false;
                check_Hamburguesa4.Enabled = false;
                check_Hamburguesa5.Enabled = false;
                check_Hamburguesa6.Enabled = false;
                check_Hamburguesa7.Enabled = false;
                check_Hamburguesa8.Enabled = false;
                check_Hamburguesa9.Enabled = false;
                check_Hamburguesa10.Enabled = false;
                check_Hamburguesa11.Enabled = false;
                check_Hamburguesa12.Enabled = false;

                //Tacos
                check_Tacos.Enabled = false;
                check_Tacos1.Enabled = false;
                check_Tacos2.Enabled = false;
                check_Tacos3.Enabled = false;
                check_Tacos4.Enabled = false;
                check_Tacos5.Enabled = false;
                check_Tacos6.Enabled = false;
                check_Tacos7.Enabled = false;
                check_Tacos8.Enabled = false;
                check_Tacos9.Enabled = false;
                check_Tacos10.Enabled = false;

                //Hotdog
                check_Hotdog4.Enabled = false;
                check_Hotdog5.Enabled = false;
                check_Hotdog6.Enabled = false;
                check_Hotdog7.Enabled = false;
                check_Hotdog8.Enabled = false;
                check_Hotdog9.Enabled = false;
                check_Hotdog10.Enabled = false;
                check_Hotdog11.Enabled = false;
                check_Hotdog12.Enabled = false;
                check_Hotdog13.Enabled = false;

                //Activar
                check_Hotdog1.Enabled = true;
                check_Hotdog2.Enabled = true;
                check_Hotdog3.Enabled = true;
            }
        }
        private void check_Hotdog1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Hotdog1.Checked == true)
            {
                check_Hotdog2.Enabled = false;
                check_Hotdog3.Enabled = false;

                //Activar
                check_Hotdog4.Enabled = true;
                check_Hotdog5.Enabled = true;
                check_Hotdog6.Enabled = true;
                check_Hotdog7.Enabled = true;
                check_Hotdog8.Enabled = true;
                check_Hotdog9.Enabled = true;
                check_Hotdog10.Enabled = true;
                check_Hotdog11.Enabled = true;
                check_Hotdog12.Enabled = true;
                check_Hotdog13.Enabled = true;

            }
        }

        private void check_Hotdog2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Hotdog2.Checked == true)
            {
                check_Hotdog1.Enabled = false;
                check_Hotdog3.Enabled = false;

                //Activar
                check_Hotdog4.Enabled = true;
                check_Hotdog5.Enabled = true;
                check_Hotdog6.Enabled = true;
                check_Hotdog7.Enabled = true;
                check_Hotdog8.Enabled = true;
                check_Hotdog9.Enabled = true;
                check_Hotdog10.Enabled = true;
                check_Hotdog11.Enabled = true;
                check_Hotdog12.Enabled = true;
                check_Hotdog13.Enabled = true;
            }

        }

        private void check_Hotdog3_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Hotdog3.Checked == true)
            {
                check_Hotdog1.Enabled = false;
                check_Hotdog2.Enabled = false;

                //Activar
                check_Hotdog4.Enabled = true;
                check_Hotdog5.Enabled = true;
                check_Hotdog6.Enabled = true;
                check_Hotdog7.Enabled = true;
                check_Hotdog8.Enabled = true;
                check_Hotdog9.Enabled = true;
                check_Hotdog10.Enabled = true;
                check_Hotdog11.Enabled = true;
                check_Hotdog12.Enabled = true;
                check_Hotdog13.Enabled = true;
            }
        }

        private void check_Tacos2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Tacos2.Checked == true)
            {
                check_Tacos1.Enabled = false;
                check_Tacos3.Enabled = false;

                //Activar
                check_Tacos4.Enabled = true;
                check_Tacos5.Enabled = true;
                check_Tacos6.Enabled = true;
                check_Tacos7.Enabled = true;
                check_Tacos8.Enabled = true;
                check_Tacos9.Enabled = true;
                check_Tacos10.Enabled = true;
            }
            
        }
        private void check_Tacos3_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Tacos3.Checked == true)
            {
                check_Tacos1.Enabled = false;
                check_Tacos2.Enabled = false;

                //Activar
                check_Tacos4.Enabled = true;
                check_Tacos5.Enabled = true;
                check_Tacos6.Enabled = true;
                check_Tacos7.Enabled = true;
                check_Tacos8.Enabled = true;
                check_Tacos9.Enabled = true;
                check_Tacos10.Enabled = true;
            }
        }

        private void check_Hamburguesa1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Hamburguesa1.Checked == true)
            {
                check_Hamburguesa2.Enabled = false;
                check_Hamburguesa3.Enabled = false;

                //Activar
                check_Hamburguesa4.Enabled = true;
                check_Hamburguesa5.Enabled = true;
                check_Hamburguesa6.Enabled = true;
                check_Hamburguesa7.Enabled = true;
                check_Hamburguesa8.Enabled = true;
                check_Hamburguesa9.Enabled = true;
                check_Hamburguesa10.Enabled = true;
                check_Hamburguesa11.Enabled = true;
                check_Hamburguesa12.Enabled = true;
            }
        }
        private void check_Hamburguesa2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Hamburguesa2.Checked == true)
            {
                check_Hamburguesa3.Enabled = false;
                check_Hamburguesa1.Enabled = false;

                //Activar
                check_Hamburguesa4.Enabled = true;
                check_Hamburguesa5.Enabled = true;
                check_Hamburguesa6.Enabled = true;
                check_Hamburguesa7.Enabled = true;
                check_Hamburguesa8.Enabled = true;
                check_Hamburguesa9.Enabled = true;
                check_Hamburguesa10.Enabled = true;
                check_Hamburguesa11.Enabled = true;
                check_Hamburguesa12.Enabled = true;
            }
        }
        private void check_Hamburguesa3_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Hamburguesa3.Checked == true)
            {
                check_Hamburguesa2.Enabled = false;
                check_Hamburguesa1.Enabled = false;

                //Activar
                check_Hamburguesa4.Enabled = true;
                check_Hamburguesa5.Enabled = true;
                check_Hamburguesa6.Enabled = true;
                check_Hamburguesa7.Enabled = true;
                check_Hamburguesa8.Enabled = true;
                check_Hamburguesa9.Enabled = true;
                check_Hamburguesa10.Enabled = true;
                check_Hamburguesa11.Enabled = true;
                check_Hamburguesa12.Enabled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            //Tacos
            if (check_Tacos1.Checked == true)
            {
                txtOrden.Text = "Tacos de Trompo             ";

            } else if (check_Tacos2.Checked == true)
            {
                txtOrden.Text = "Tacos de Bisteck              " ;

            } else if (check_Tacos3.Checked == true)
            {
                txtOrden.Text = "Tacos de Campechana     " ;
            }

            //Tacos ingredientes
            if (check_Tacos4.Checked == false )
            {
                txtOrden.Text += "-Sin Queso                          ";

            }
            if(check_Tacos6.Checked == true)
            {
                txtOrden.Text += "-Con Tortilla de maiz      ";

            }
            if (check_Tacos7.Checked == true)
            {
                txtOrden.Text += "-Con Tortilla de harina    ";

            }
            if(check_Tacos9.Checked == true)
            {
                txtOrden.Text += "-Salsa Verde          ";

            }
            if(check_Tacos10.Checked == true)
            {
                txtOrden.Text += "-Salsa Roja";
            }

            //Hamburguesas
            if (check_Hamburguesa1.Checked == true)
            {
                txtOrden.Text = "Hamburguesa Especial      ";

            } else if (check_Hamburguesa2.Checked == true)
            {
                txtOrden.Text = "Hamburguesa Doble       " ;

            } else if (check_Hamburguesa3.Checked == true)
            {
                txtOrden.Text = "Hamburguesa de Trompo ";
            }

            //Hamburguesas ingredientes
            if(check_Hamburguesa4.Checked == false)
            {
                txtOrden.Text += "-Sin Queso amarillo         ";
            }
            if (check_Hamburguesa5.Checked == false)
            {
                txtOrden.Text += "-Sin Queso blanco            ";
            }
            if (check_Hamburguesa6.Checked == false)
            {
                txtOrden.Text += "-Sin Lechuga                     ";
            }
            if (check_Hamburguesa7.Checked == false)
            {
                txtOrden.Text += "-Sin Tomate                      ";
            }
            if (check_Hamburguesa8.Checked == false)
            {
                txtOrden.Text += "-Sin Cebolla                      ";
            }
            if (check_Hamburguesa9.Checked == false)
            {
                txtOrden.Text += "-Sin Moztaza                      ";
            }
            if (check_Hamburguesa10.Checked == false)
            {
                txtOrden.Text += "-Sin Captsup                      ";
            }
            if (check_Hamburguesa11.Checked == false)
            {
                txtOrden.Text += "-Sin Mayonesa                    ";
            }
            if (check_Hamburguesa12.Checked == false)
            {
                txtOrden.Text += "-Sin Aguacate                       ";
            }

            //Hotdog
            if(check_Hotdog1.Checked == true)
            {
                txtOrden.Text = "Hotdog Normal               ";

            }else if (check_Hotdog2.Checked == true)
            {
                txtOrden.Text = "Hotdog Extra largo         " ;

            }else if(check_Hotdog3.Checked == true)
            {
                txtOrden.Text = "Hotdog Jumbo                 " ;
            }

            //Hotdog ingredientes
            if (check_Hotdog4.Checked == false)
            {
                txtOrden.Text += "-Sin Cebolla                       ";
            }
            if (check_Hotdog5.Checked == false)
            {
                txtOrden.Text += "-Sin Tomate                        ";
            }
            if (check_Hotdog6.Checked == false)
            {
                txtOrden.Text += "-Sin Pepinillos                     ";
            }
            if (check_Hotdog7.Checked == false)
            {
                txtOrden.Text += "-Sin Mostaza                        ";
            }
            if (check_Hotdog8.Checked == false)
            {
                txtOrden.Text += "-Sin Mayonesa                    ";
            }
            if (check_Hotdog9.Checked == false)
            {
                txtOrden.Text += "-Sin Crema                           ";
            }
            if (check_Hotdog10.Checked == false)
            {
                txtOrden.Text += "-Sin Queso amarillo         ";
            }
            if (check_Hotdog11.Checked == false)
            {
                txtOrden.Text += "-Sin Tocino                        ";
            }
            if (check_Hotdog12.Checked == false)
            {
                txtOrden.Text += "-Sin Chile jalapeño         ";
            }
            if (check_Hotdog13.Checked == false)
            {
                txtOrden.Text += "-Sin Chile toreado        ";
            }
            

            //Torta
            if (check_Tortas1.Checked == true)
            {
                txtOrden.Text = "Torta de Pierna ";
               
            }else if(check_Tortas2.Checked == true)
            {
                txtOrden.Text = "Torta de Milanesa " ;

            }else if(check_Tortas3.Checked == true)
            {
                txtOrden.Text = "Torta Cubana ";
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}