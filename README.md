# SerialPortFMX
Biblioteca para leitura de porta serial em C#.


# createPort
Método utilizado para instanciar uma porta COM.
**Parametros:** Uma string contendo o nome da porta serial, como por exemplo: createPort("COM6").
**Retorno**: (N/A)

# portStatus
Método utilizado para retornar um status de conexão com a porta. 
**Parametros:** (N/A)
**Retorno:** Valor boolean sendo 1 para open e 0 para close.

# openPort
Método utilizado para abrir a conexão com a porta COM, sempre deve ser utilizado antes da leitura/escrita da porta.
**Parametro:** (N/A)**
Retorno:** (N/A)

#closePort
Método utilizado para fechar a porta quando seu uso não for mais necessário.
**Parametros:** (N/A)
**Retorno:** (N/A)

#sendRequest
Método utilizado para escrever/enviar um valor em formato de string para a porta COM.
**Parametros:** Um string contendo o valor a ser escrito/recebido pela porta, como por exemplo: sendRequest("{RW}").
**Retorno:** (N/A)

#getResponse
Método responsável por retornar o valor enviado pela porta.
**Parametros**: (N/A)
**Retorno**: Uma string contendo o valor da leitura.
