using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codificador
{
    public partial class Form1 : Form
    {
        char[] mensaje = new char[100];
        int[] mensaje_ascii = new int[100];
        char[,] binario = new char[100, 8];
        char[] clave = new char[100];
        int[] clave_ascii = new int[100];
        char[,] llavebin = new char[100, 8];
        char[,] conversion = new char[100, 8];
        string cla;
        string message;
        int tamaño_mes;
        int tamaño_llave;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_codificar_Click(object sender, EventArgs e)
        {
            limpiar_bin();
            message = mensaje_Acod.Text;
            tamaño_mes = message.Length;
            mensaje = message.ToCharArray();
            cla = txt_llave.Text;
            clave = cla.ToCharArray();
            tamaño_llave = cla.Length;
            ascii();
            llenar_bin();
            XOR();
            XOR_ascii();
            ascii_char();
            mensaje_cod.Text = message;
        }

        private void btn_decodificar_Click(object sender, EventArgs e)
        {
            mensaje_cod.Clear();
            mensaje_Decod.Clear();
            limpiar_bin();
            message = mensaje_aDecod.Text;
            tamaño_mes = message.Length;
            mensaje = message.ToCharArray();
            cla = txt_llave.Text;
            clave = cla.ToCharArray();
            tamaño_llave = cla.Length;
            ascii();
            llenar_bin();
            XOR();
            XOR_ascii();
            ascii_char();
            mensaje_Decod.Text = message;
        }

        private void ascii()
        {
            int count = tamaño_llave -1;
            for(int i = 0; i < tamaño_mes; i++)
            {
                int ValorASCII = (int)mensaje[i];
                mensaje_ascii[i] = ValorASCII;
            }
            for(int i = 0; i < 100; i++)
            {
                if(count < 0)
                {
                    count = tamaño_llave -1;
                }
                int ValorrASCII = (int)clave[count];
                clave_ascii[i] = ValorrASCII;
                count--;
            }
        }

        private void llenar_bin()
        {
            //Mensaje
            for(int i = 0; i < tamaño_mes; i++)
            {
                string bin = Convert.ToString(mensaje_ascii[i],2);
                int tamaño_bin = bin.Length;
                char[] array_bin = bin.ToCharArray();
                int count = 7; //Contador para posición en la matriz
                for (int j = tamaño_bin; j > 0; j--) 
                {
                    binario[i, count] = array_bin[j-1];
                    count--;
                }
            }
            //Clave
            for (int i = 0; i < 100; i++)
            {
                string bin = Convert.ToString(clave_ascii[i], 2);
                int tamaño_bin = bin.Length;
                char[] array_bin = bin.ToCharArray();
                int count = 7;
                for (int j = tamaño_bin; j > 0; j--)
                {
                    llavebin[i, count] = array_bin[j-1];
                    count--;
                }
                
            }

        }

        private void XOR()
        {
            for(int i = 0; i < tamaño_mes; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (binario[i, j] == '1' && llavebin[i, j] == '1')
                    {
                        conversion[i, j] = '0';
                    }
                    if (binario[i, j] == '0' && llavebin[i, j] == '1')
                    {
                        conversion[i, j] = '1';
                    }
                    if (binario[i, j] == '1' && llavebin[i, j] == '0')
                    {
                        conversion[i, j] = '1';
                    }
                    if (binario[i, j] == '0' && llavebin[i, j] == '0')
                    {
                        conversion[i, j] = '0';
                    }
                }
            }
        }

        private void XOR_ascii()
        {
            

            for(int i = 0; i < tamaño_mes; i++)
            {
                char[] temp = new char[8];
                for (int k = 0; k < 7; k++)
                {
                    temp[k] = conversion[i, k];
                }
                Array.Reverse(temp);
                int ascii = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (temp[j] == '1')
                    {
                        //Potencia 2 segun posición
                        ascii += (int)Math.Pow(2, j);
                    }
                }
                mensaje_ascii[i] = ascii; 
            }
        }

        private void ascii_char()
        {
            for(int i = 0; i < tamaño_mes; i++)
            {
                mensaje[i] = Convert.ToChar(mensaje_ascii[i]);
            }
            message = new string(mensaje);
        }

        private void limpiar_bin()
        {
            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    binario[i, j] = '0';
                    llavebin[i, j] = '0';
                    conversion[i, j] = '0';
                }
            }


        }

    }
}
