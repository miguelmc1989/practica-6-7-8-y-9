/*
 * Created by SharpDevelop.
 * User: Owner
 * Date: 6/2/2014
 * Time: 6:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace practica6_7_8_9
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opc = 5;
			
			do{
				Console.WriteLine("Menu");
				Console.WriteLine("1: Ver");
				Console.WriteLine("2: Agregar");
				Console.WriteLine("3: Editar");
				Console.WriteLine("4: Eliminar");
				Console.WriteLine("5: Salir");
				Console.WriteLine("Elige una opcion");
				
				profesores prof = new profesores();
				
				switch(Console.Read())
				{
					case '1':
						Console.WriteLine("Listado de Profesores");
						prof.Mostrartodos();
						Console.ReadKey(true);
						Console.WriteLine("Presiona cualquier tecla para regresar al menu");
						Console.ReadLine();
						break;
						
					case '2':
						Console.WriteLine("Agregar Nuevo registro");
						Console.WriteLine("Digite el codigo de Profesor");
						Console.ReadLine();
						string codigo = Console.ReadLine();
						Console.WriteLine("Agregar Nombre");
						string nombre = Console.ReadLine();
						prof.insertarRegistroNuevo(codigo,nombre);
						Console.WriteLine("Presiona cualquier tecla para regresar al menu");
						Console.ReadLine();
						break;
						
					case '3':
						Console.WriteLine("Menu para Editar");
						Console.WriteLine("Ingrese el ID que va a editar");
						Console.ReadLine();
						string id = Console.ReadLine();
						
						if (prof.Buscarid(id))
							
						{
							Console.WriteLine("Estas seguro de continuar?");
							string dig = Console.ReadLine();
							
							if (dig == "s")
							{
								Console.WriteLine("Ingrese el codigo");
								codigo = Console.ReadLine();
								Console.WriteLine("Ingrese el nombre");
								nombre = Console.ReadLine();
								prof.editar(id,codigo,nombre);
							}
						}
							else 
							{
								Console.WriteLine("El ID ingresado no existe!!!!");
								Console.ReadLine();
							}
							Console.WriteLine("Presiona cualquier tecla para regresar al menu");
						Console.ReadLine();
							break;
							
						case '4':
					  	
					  Console.WriteLine("Eliminar Profesor");
				      Console.WriteLine("ingrese el ID");
				      Console.ReadLine();
				      id = Console.ReadLine();
				      
				      if (prof.Buscarid(id))
				      {
				      	codigo = Console.ReadLine();
				      	nombre = Console.ReadLine();
				      	Console.WriteLine("seguro que desea eliminar?");
				      	string elim = Console.ReadLine();
				      	
				      	if (elim=="s")
				      	
				      		prof.eliminarRegistroPorId(id);
				      	    
				      	 }
						 
				      else 
				      {
				      	Console.WriteLine("El id no existe");
				      	Console.ReadLine();
				      	
				      }
				      Console.WriteLine("Presiona cualquier tecla para regresar al menu");
						Console.ReadLine();
				      break;
				      
				     case '5':
				  	
				  	System.Console.Clear();
				    break;
						}	
						
						System.Console.Clear();
				}
			
			while(opc<5);
			
		}
	}
}
