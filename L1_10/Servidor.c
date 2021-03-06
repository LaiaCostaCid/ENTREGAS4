#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
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
	serv_adr.sin_port = htons(9020);
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
		
		//Bucle de atenci?n al cliente
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
			char nombre[20];
			
			if(codigo!=0)
			{			
				// Ya tenemos el c?digo de petici?n
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				//Ya tenemos el nombre
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);			
			}
			
			if (codigo==0)
				terminar=1;
			else if (codigo ==1) //piden la longitd del nombre
				sprintf (respuesta,"%d",strlen (nombre));
			else if (codigo ==2)
				// quieren saber si el nombre es bonito
				if((nombre[0]=='M') || (nombre[0]=='S'))
				strcpy (respuesta,"SI");
				else
					strcpy (respuesta,"NO");
			else if(codigo==3) //quiere saber si es alto
				{
					p = strtok( NULL, "/");
					float altura =  atof (p);
					if (altura > 1.70)
						sprintf (respuesta, "%s: eres alto",nombre);
					else 
						sprintf (respuesta, "%s: eres bajo",nombre);
				}
			else if(codigo==4)
			{
				int i=0;
				while(nombre[i]!='\0')
				{
					nombre[i]=tolower(nombre[i]);
					i=i+1;
				}
				
				int first=0;
				int last=strlen(nombre)-1;
				int encontrado=0;
				
				while(first<last && encontrado!=1)
				{					
					if(nombre[first]==nombre[last])
					{
						first=first+1;
						last=last-1;
					}
					else
						encontrado=1;
					
				}
				if (encontrado==0)
					strcpy(respuesta,"SI");
				else
					strcpy(respuesta,"NO");	
													
										
			}
			else
			{	int i=0;
				while(nombre[i]!='\0')
				{
					nombre[i]=toupper(nombre[i]);
					i=i+1;
				}
				strcpy(respuesta,nombre);
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
		
			
			
			
	
	
	
	
