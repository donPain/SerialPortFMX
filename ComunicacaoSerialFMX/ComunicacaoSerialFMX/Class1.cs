using System;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace ComunicacaoSerialFMX
{
    public class Serial
    {
        static bool IsOk;
        static string Status;
        static SerialPort _serialPort = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);
        static StreamWriter sw = new StreamWriter("C:\\Test.txt");
        public static bool portStatus()
        {
            //Retorna se a porta está aberta.
            return (_serialPort.IsOpen);
        }

        public static void openPort()
        {
            //Abre a porta serial.
            _serialPort.Open();
        }

        public static string ReturnStatus()
        {
            return (Serial.Status);
        }

        public static void closePort()
        {
            //Fecha a porta serial.
            _serialPort.Close();
        }

        public static void sendRequest(string request)
        {
            
            IsOk = false;
            //Envia uma requisição para a porta.
            if (request == "{RW}")
            {
                IsOk = true;
            }
            if (IsOk == true)
            {
                _serialPort.WriteLine(request);
            }
        }

        public static string getResponse()
        {
            Serial.sendRequest("{RW}"); //Parametro fixo para teste. 
            string Peso;
            //Recebe o valor escrito pela porta.
            Peso = _serialPort.ReadExisting();
            Peso.Trim();
            if (Peso.Length > 0)
            {
                Thread.Sleep(1000);
                return (Peso);

            }
            else
            {
                return ("Sem Peso");
            }
         


        }

    }

}





