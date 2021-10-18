#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	float t;
	int temperatura;
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9010);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i;
	// bucle infinito
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
		
		//Bucle de atenci�n al cliente
		int terminar=0;
		while(terminar==0)
		{
			
			// Ahora recibimos la petici?n
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			
			// Tenemos que a?adirle la marca de fin de string 
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';			
			printf ("Peticion: %s\n",peticion);
			
			
			// vamos a ver que quieren
			char *p = strtok( peticion, "/");
			int codigo =  atoi (p);
			
			
			if(codigo!=0)
			{			
				// Ya tenemos el c?digo de petici?n
				p = strtok( NULL, "/");
				temperatura= atof(p);
				//Ya tenemos el nombre
				printf ("Codigo: %d, Temperatura: %d\n", codigo, temperatura);			
			}
			
			if (codigo==0)
				terminar=1;
			else if (codigo ==1) //pide conversion de Celsius a Farenheit
			{
				t=(temperatura*(9.0/5.0))+32;
				sprintf (respuesta,"%f",t);
			}
			else if (codigo==2)
			{
				
				t=((temperatura-32)*(5.0/9.0);
				sprintf(respuesta,"%f",t);
								
			}			

				
				
			if (codigo!=0)
			{
				printf ("Respuesta: %s\n", respuesta);
				// Enviamos la respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
		}
		
		// Se acabo el servicio para este cliente
		close(sock_conn); 
	}
}	


