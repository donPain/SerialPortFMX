using System;
using System.IO.Ports;
using System.Threading;
using System.IO;


namespace ComunicacaoSerialFMX
{
    public class Serial
    {
        static string Status;
        public static SerialPort _serialPort;       

        public static void createPort(string PortName)
        {
            _serialPort = new SerialPort(PortName, 9600, Parity.None, 8, StopBits.One);

        }
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
            string Parametro;
            Parametro = request;

            //using (streamwriter writer = new streamwriter("c:\\log.txt", true))
            //{
            //    writer.writeline("request linha 49 :" + request);
            //}
            //Envia uma requisição para a porta.
            _serialPort.WriteLine(request);
        }

            public static string getResponse()
        {
            string Peso;
            //_serialPort.WriteLine("{RW}");
            //Recebe o valor escrito pela porta.
            Peso = _serialPort.ReadExisting();
            Peso.Trim();
            if (Peso.Length > 0)
            {
                Serial.Status = "200";
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





