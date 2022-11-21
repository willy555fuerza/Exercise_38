using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcionTemporal;
            int opcion = 0;
            int x;
            //variables operaciones
            double a, b, c, d, i, aux, factorial;
            int impares = 0;
            string a1;
            int horas = 0, min = 0, segundos = 0;

            do
            {
                
                Console.WriteLine("\n\t\t\t\t Menu de opciones de 38 ejercicios\n  ***********************************************************************************************************************************");
                Console.WriteLine("1 Suma                                          **********                      ******     ************     *********                   *******************************************");
                Console.WriteLine("2 Resta                                         **********                      ******     ************     *********     *********************************************************");
                Console.WriteLine("3 Multiplicacion                                ******************     ***************     ************     *********     *********************************************************");
                Console.WriteLine("4 Division                                      ******************     ***************     ************     *********     *********************************************************");
                Console.WriteLine("5 Hallar el area de un cuadrado                 ******************     ***************                      *********                   *******************************************");
                Console.WriteLine("6 Hallar el area de un triangulo                ******************     ***************     ************     *********     *********************************************************");
                Console.WriteLine("7 Hallar la hipotenusa de un triangulo          ******************     ***************     ************     *********     *********************************************************");
                Console.WriteLine("8 Hallar el cateto adyacente de un triangulo    ******************     ***************     ************     *********     *********************************************************");
                Console.WriteLine("9 Hallar el cateto opuesto de un triangulo      ******************     ***************     ************     *********     *********************************************************");
                Console.WriteLine("10 Hallar el perimeto de un circulo             ******************     ***************     ************     *********                   *******************************************");
                Console.WriteLine("11 Hallaer el area un circulo                   ***********************************************************************************************************************************");
                Console.WriteLine("12 Hallar el volumen de un cilindro             ***********************************************************************************************************************************");
                Console.WriteLine("13 Hallar el area de un rombo                   ***********************************************************************************************************************************");
                Console.WriteLine("14 Suma de numeros controlando que no se 0      ***********************************************************************************************************************************");
                Console.WriteLine("15 Suma con distinto                            ***************                   *********                  ********                   ******                     ****************");
                Console.WriteLine("16 Suma con decision por falso                  ***************       *******      ********     *********************     ********************                     ****************");
                Console.WriteLine("17 Multiplicacion controlado por 0              *****************     *******      ********     *********************     ***************************      ************************");
                Console.WriteLine("18 Dados 2 numeros Mayor y menor                *****************     *******      ********     *********************     ***************************      ************************");
                Console.WriteLine("19 Calificaciones                               *****************                  ********                  ********                   *************      ************************");
                Console.WriteLine("20 Kilometro reccorrido en moto                 *****************     *******      ********     ***********************************     *************      ************************");
                Console.WriteLine("21 Porcentaje de lluvia                         *****************     *******      ********     ***********************************     *************      ************************");
                Console.WriteLine("22 Maquina de tornillos                         *****************     *******      ********     ***********************************     *************      ************************");
                Console.WriteLine("23 Mayor y menor de 3 numeros                   ****************      *******      ********     ***********************************     *************      ************************");
                Console.WriteLine("24 Sueldo aumento                               ****************                  *********                  ********                   *************      ************************");
                Console.WriteLine("25 Divisible entre 14                           ***********************************************************************************************************************************");
                Console.WriteLine("26 Calcular IMC                                 ***********************************************************************************************************************************");
                Console.WriteLine("27 Divisible entre 2 y 5                        ***********************************************************************************************************************************");
                Console.WriteLine("28 Calcular vuelto de la tienda                 ***********************************************************************************************************************************");
                Console.WriteLine("29 Bucle del 1 al 10                            ***********************************************************************************************************************************");
                Console.WriteLine("30 Contar 2 en 2                                ***********************************************************************************************************************************");
                Console.WriteLine("31 Contar numeros impares                       ***********************************************************************************************************************************");
                Console.WriteLine("32 Multiplos de 3 y decir para o impar          ***********************************************************************************************************************************");
                Console.WriteLine("33 Reloj                                        ***********************************************************************************************************************************");
                Console.WriteLine("34 Serie fibonacci                              ***********************************************************************************************************************************");
                Console.WriteLine("35 Numero de dias                               ***********************************************************************************************************************************");
                Console.WriteLine("36 mayor de numeros                             ***********************************************************************************************************************************");
                Console.WriteLine("37 Ordenar de mayor a menor                     ************************************************************************************************************************************");
                Console.WriteLine("38 factorial de un numero \n                    ***********************************************************************************************************************************");
                Console.WriteLine("\t\t\t\t Eliga una de las opciones:" + " \n\t\t\t\t Para salir 70 ");

                opcionTemporal = Console.ReadLine();
                if (int.TryParse(opcionTemporal, out x))
                {
                    opcion = int.Parse(opcionTemporal);
                    Console.Clear();
                    switch (opcion)
                    {
                        //suma
                        case 1:
                            Console.Write("Ingrese el primer valor: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese el segundo valor: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            //c = a + b; 
                            //Console.WriteLine("La suma de {0} + {1} es = {2}", a, b,(a + b));
                            Console.WriteLine($"La suma de {a} + {b} es = {a + b} ");
                            break;
                        //resta
                        case 2:
                            Console.Write("Ingrese el primer valor: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese el segundo valor: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"La resta de {a} - {b} es = {a - b} ");
                            break;
                        //multiplicaion
                        case 3:
                            Console.Write("Ingrese el primer valor: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese el segundo valor: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"La Multiplicacion de {a} x {b} es = {a * b} ");
                            break;
                        //division
                        case 4:
                            Console.Write("Ingrese el primer valor: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese el segundo valor: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"La Division de {a} / {b} es = {a / b} ");
                            break;
                        //area de un cuadrado
                        case 5:
                            Console.Write("Digite la longitud del cuadrado: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El area del cuadrado es:  {a * a}");
                            break;
                        //area de un triangulo
                        case 6:
                            Console.Write("Ingrese la Base: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese la altura del triangulo: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"El area del triangulo es:^{b * a / 2}");
                            break;
                        //Hallar la hipotenusa de un triangulo
                        case 7:
                            Console.Write("Ingresa el valor de cateto a: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa el valor de cateto b: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            c = Math.Sqrt(a * a + b * b);
                            Console.WriteLine($"La hipotenusa es: {c}");
                            break;
                        //Hallar el cateto adyacente de un triangulo
                        case 8:
                            Console.Write("Ingresa el valor de cateto opuesto: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa el valor de la hipotenusa: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            c = Math.Sqrt(a * a - b * b);
                            Console.WriteLine($"El cateto adyacente es: {c}");
                            break;
                        //Hallar el cateto opuesto de un triangulo
                        case 9:
                            Console.Write("Ingresa el valor de cateto a: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa el valor de la hipotenusa: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            c = Math.Sqrt(a * a - b * b);
                            Console.WriteLine($"El cateto opuesto es: {c}");
                            break;
                        //Hallar el perimeto de un circulo
                        case 10:
                            Console.Write("Ingrese la distancia (radio): ");
                            a = Convert.ToDouble(Console.ReadLine());
                            c = 2 * 3.1416 * a;
                            Console.WriteLine($"el Perimetro del circulo es : {c}");
                            break;
                        //11 Hallaer el area un circulo
                        case 11:
                            Console.Write("Ingrese la distancia (radio): ");
                            a = Convert.ToDouble(Console.ReadLine());
                            c = 3.1416 * (a * a);
                            Console.WriteLine($"El area de un circulo es : {c}");
                            break;
                        //12 Hallar el volumen de un cilindro
                        case 12:
                            Console.Write("Ingrese la base del cilindro: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese la altura del cilindro: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            c = 3.1416 * (a * a) * b;
                            Console.WriteLine($"El volumen del cilindro es: {c}");
                            break;
                        //13 Hallar el area de un rombo
                        case 13:
                            Console.Write("Ingrese la Diagonal Mayor: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese la diagonal menor: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            c = a * b / 2;
                            Console.WriteLine($"El area de un rombo es: {c}");
                            break;
                        //14 Suma de numeros controlando que no se 0");
                        case 14:
                            do
                            {
                                Console.Write("Ingrese el primer digito: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese segundo digito: ");
                                b = Convert.ToDouble(Console.ReadLine());
                                if (a == 0 || b == 0)
                                {
                                    Console.WriteLine("\nUno de los valores es 0");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine($"La suma de {a} + {b} es = {a + b}");
                                }

                            } while (a == 0);
                            break;
                        //15 Distinto, igual
                        case 15:
                            do
                            {
                                Console.Write("Ingrese el primer digito: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese segundo digito: ");
                                b = Convert.ToDouble(Console.ReadLine());
                                if (a == 0)
                                {
                                    Console.WriteLine($"\n el primer digito es {a}");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                    if (b == 0)
                                {
                                    Console.WriteLine($"\n el segundo digito es {b}");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine($"La suma de {a} + {b} es = {a + b}");
                                }

                            } while (a == 0 || b == 0);
                            break;
                        //16 Suma con distinto
                        case 16:
                            do
                            {
                                Console.Write("Ingrese el primer digito: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese segundo digito: ");
                                b = Convert.ToDouble(Console.ReadLine());
                                if (a != 0)
                                {
                                    if (b != 0)
                                    {
                                        Console.WriteLine($"La suma de {a} + {b} es = {a + b}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n el segundo digito es: {b}");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                }
                                else
                                {
                                    Console.WriteLine($"\n el primer digito es: {a}");
                                    Console.ReadKey();
                                    Console.Clear();
                                }

                            } while (a == 0 || b == 0);
                            break;

                        //17 Multiplicacion controlado por 0");
                        case 17:
                            do
                            {
                                Console.Write("Ingrese el primer digito: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese segundo digito: ");
                                b = Convert.ToDouble(Console.ReadLine());
                                if (a == 0 || b == 0)
                                {
                                    Console.WriteLine("\nUno de los valores es 0");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine($"La suma de {a} x {b} es = {a * b}");
                                }

                            } while (a == 0 || b == 0);
                            break;
                        //18 Dados 2 numeros Mayor y menor");
                        case 18:
                            do
                            {
                                Console.Write("Ingrese el primer digito: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese segundo digito: ");
                                b = Convert.ToDouble(Console.ReadLine());
                                if (a != 0 || b != 0)
                                {
                                    if (a != b)
                                    {
                                        if (a > b)
                                        {
                                            Console.WriteLine($"{a} es mayor y {b} es menor");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{b} es mayor y {a} es menor");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ambos digitos son iguales");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ambos digitos son ceros");
                                }
                            } while (a != 0 && b != 0 && a != b);
                            break;
                        //19 nivel de calificaciones";
                        case 19:
                            do
                            {
                                Console.WriteLine("Ingrese su nota del 0 al 100: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                if (a <= 100)
                                {
                                    if (a >= 61)
                                    {
                                        if (a >= 70)
                                        {
                                            if (a >= 80)
                                            {
                                                if (a >= 100)
                                                {
                                                    Console.WriteLine("Perfecto");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Exelente");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Bueno");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Aprobado");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Reprobado");
                                    }
                                }
                                else
                                {
                                    Console.Clear();

                                }
                            } while (a > 100);
                            break;
                        //20 Kilometros por hora
                        case 20:
                            double distancia, tiempo, velocidad;
                            Console.Write("tiempo en k/h: ");
                            distancia = Convert.ToDouble(Console.ReadLine());
                            Console.Write("distancia kilometros: ");
                            tiempo = Convert.ToDouble(Console.ReadLine());
                            velocidad = tiempo / distancia;
                            Console.WriteLine($"La velocidad es {velocidad} km/h");
                            break;
                        //21 Porcentaje de lluvia");
                        case 21:
                            do
                            {
                                Console.WriteLine("Dias de lluvia; ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a <= 365)
                                {
                                    c = a * 100 / 365;
                                    Console.WriteLine($"{c}% en todo el año de lluvia");
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese los dias en base de 365 dias del año");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            } while (a > 365);
                            break;
                        // 22 Fabrica de tornillos
                        case 22:
                            do
                            {
                                Console.Write("Horas: ");
                                a = float.Parse(Console.ReadLine());
                                Console.Write("Tornillos en Unidad por Hora: ");
                                b = float.Parse(Console.ReadLine());
                                int tornillosDeseados;
                                Console.Write("Tornillos en unidad a Calcular: ");
                                tornillosDeseados = Convert.ToInt32(Console.ReadLine());
                                if (a <= 0 | b <= 0 | tornillosDeseados <= 0)
                                {

                                    Console.Write("Ingrese datos correctos ");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    c = a * tornillosDeseados / b;
                                    Console.Write($"\nSe fabricaran en {tornillosDeseados} tornillos en: {c} horas");
                                }
                            } while (a > 0 || b > 0);
                            break;
                        //"23 Mayor y menor de 3 numeros");
                        case 23:
                            Console.Write("Ingrese el primer valor: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese el segundo valor: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese el tercer valor: ");
                            c = Convert.ToDouble(Console.ReadLine());
                            if (a > b)
                            {
                                if (c > b)
                                {
                                    if (a > c)
                                    {
                                        Console.WriteLine($"El Mayor es {a} y el menor es {b}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"El Mayor es {c} y el menor es {b}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"El Mayor es {a} y el menor es {c}");
                                }
                            }
                            else
                            {
                                if (b < c)
                                {
                                    Console.WriteLine($"El Mayor es {c} y el menor es {a}");
                                }
                                else
                                {
                                    if (a > c)
                                    {
                                        Console.WriteLine($"El Mayor es {b} y el menor es {c}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"El Mayor es {b} y el menor es {a}");
                                    }

                                }
                            }
                            break;
                        //24 Sueldo aumento
                        case 24:
                            Console.Write("Ten en cuenta:\n\tMayor a Bs. 1000\t15%\n\tMayor a Bs. 2000\t10%\n\tMayor a Bs. 3000\t5%\n");
                            Console.Write("Ingrese su sueldo mensual en bolivianos: ");
                            a = Double.Parse(Console.ReadLine());
                            if (a >= 3000)
                            {
                                c = a * 5 / 100;
                                Console.WriteLine($"\nSu aumento es de Bs.{c}\tSuelo final es de: Bs. {a + c}");
                            }
                            else
                            {
                                if (a >= 2000)
                                {
                                    c = a * 10 / 100;
                                    Console.WriteLine($"\nSu aumento es de Bs. {c}\tSuelo final es de: Bs. {a + c}");
                                }
                                else
                                {
                                    c = a * 15 / 100;
                                    Console.WriteLine($"\nSu aumento es de Bs. {c}\tSuelo final es de: Bs. {a + c}");
                                }
                            }
                            break;
                        //25 Divisible entre 14
                        case 25:
                            Console.Write("Inserte un numero: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            if (a % 14 == 0)
                            {
                                Console.WriteLine($"El numero {a} es divisible entre 14");
                            }
                            else
                            {
                                Console.WriteLine($"El numero {a} NO es divisible entre 14");
                            }
                            break;
                        //Console.WriteLine("26 Calcular IMC");           FALTA
                        case 26:
                            Console.Write("Ingrese su peso actual : ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese su altura actual : ");
                            b = Convert.ToDouble(Console.ReadLine());
                            c = Math.Round(a / (double)Math.Pow(b, 2));
                            a1 = Convert.ToString(c);
                            if (c <= 18)
                            {
                                Console.WriteLine("Estas Delgado");
                            }
                            else
                            {
                                if (c <= 26)
                                {
                                    Console.WriteLine("Estas con peso Normal");
                                }
                                else
                                {
                                    if (c <= 30)
                                    {
                                        Console.WriteLine("Estas con Obesidad");
                                    }
                                }
                            }
                            break;

                        //27 Divisible entre 2 y 5
                        case 27:
                            Console.Write("\t\t\t**************** Divisible entre 2 y 5 ****************\n\n");
                            Console.Write("Digite el numero: ");
                            Console.Write("");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\n");
                            if (a % 2 == 0)
                            {
                                Console.WriteLine(a + " Es divisible entre 2 ");
                            }
                            else
                            {
                                Console.WriteLine(a + " No es divisible entre 2 ");
                            }
                            if (a % 5 == 0)
                            {
                                Console.WriteLine(a + " Es divisible entre 5 ");
                            }
                            else
                            {
                                Console.WriteLine(a + " No es divisible entre 5 ");
                            }

                            break;

                        //28 Calcular vuelto de la tienda
                        case 28:
                            Console.Write("\t\t\t**************** 28 Calcular vuelto de la tienda ****************\n\n");
                            Console.Write("Por favor digite el precio del producto en Bs. ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Inserte su dinero en Bs. ");
                            b = Convert.ToDouble(Console.ReadLine());
                            if (a < b)
                            {
                                c = b - a;
                                Console.WriteLine($"\nSu compra del producto es de Bs. {a}, su cambio es de Bs. {c}");
                            }
                            else
                            {
                                Console.WriteLine($"\nUsted no puede comprar el producto de Bs. {a}, ya que usted no posee suficiente dinero");
                            }
                            break;

                        //29 Bucle del 1 al 10
                        case 29:
                            Console.Write("\t\t\t**************** Bucle del 1 al 10 ****************\n\n");
                            Console.Write("\nPrecione enter para comenzar\n");
                            Console.Read();
                            for (i = 1; i <= 10; i++)
                            {
                                Console.WriteLine("\tBucle " + i);
                            }
                            break;
                        //30 Contar 2 en 2
                        case 30:
                            Console.Write("\t\t\t**************** 30 Contar 2 en 2 ****************\n\n");
                            Console.Write("\nPor favor ingrese el numero donde quiera comenzar: ");
                            a = Convert.ToInt16(Console.ReadLine());
                            Console.Write("\nHasta que numero: ");
                            b = Convert.ToInt16(Console.ReadLine());
                            for (i = a; i <= b; i += 2)
                            {
                                Console.WriteLine("\nBucle " + i);
                            }
                            break;
                        //31 Contar numeros impares
                        case 31:
                            Console.Write("\t\t\t**************** 31 Contar numeros impares ****************\n\n");
                            Console.Write("\nPor favor ingrese el numero donde quiera comenzar: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nHasta que numero: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            for (i = a; i <= b; i++)
                            {
                                if (i % 2 != 0)
                                {
                                    Console.WriteLine("Bucle " + i);
                                    impares++;
                                }

                            }
                            Console.WriteLine("\nHay " + impares + " impares");
                            break;

                        //32 Multiplos de 3 y decir para o impar
                        case 32:
                            Console.Write("\t\t\t****************. 32 Multiplos de 3 y decir par o impar ****************\n\n");
                            Console.Write("\nPor favor ingrese el numero donde quiera comenzar: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nHasta que numero: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            impares = 0;
                            for (i = a; i <= b; i += 3)
                            {
                                if (i % 2 == 0)
                                {
                                    Console.WriteLine(i + " Par");

                                }
                                else
                                {
                                    Console.WriteLine(i + " impar");
                                }
                            }
                            break;

                        //33 Reloj
                        case 33:
                            Console.Write("\t\t\t**************** 32 Reloj ****************\n\n");
                            while (horas <= 23)
                            {
                                while (min < 60)
                                {
                                    while (segundos < 60)
                                    {
                                        Console.WriteLine($"\n\n\n\n\t\t\t\t\t{horas} : {min} : {segundos}");
                                        segundos++;
                                        Thread.Sleep(10);
                                        Console.Clear();
                                    }
                                    segundos = 0;
                                    min = min + 1;
                                }
                                min = 0;
                                horas = horas + 1;
                                if (horas == 24)
                                {
                                    horas = 0;
                                }
                            }
                            break;

                        //34 Serie fibonacci
                        case 34:
                            Console.Write("\t\t\t**************** 34 Serie Fibonacci ****************\n\n");
                            Console.Write("\nCuantos numeros de la serie Fibonacci desea ver?: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            b = 0;
                            c = 1;
                            Console.Write($"{b} , {c} , ");
                            for (i = 3; i < a; i++)
                            {
                                aux = b;
                                b = c;
                                c = aux + b;
                                Console.Write(c + " , ");
                            }
                            break;

                        //35 Numero de dias
                        case 35:
                            Console.Write("\t\t\t**************** 35 Numero de dias *****************\n\n");
                            Console.Write("\nPor favor ingrese los dias que desa calcular: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            while (a > 0)
                            {
                                b = a / 365;
                                c = a / 30;
                                d = a / 7;
                                Console.WriteLine("Dada la cantidad ingreseda se tiene:\n ");
                                Console.WriteLine(Math.Round(b) + " Años");
                                Console.WriteLine(Math.Round(c) + " Meses");
                                Console.WriteLine(Math.Round(d) + " Semanas");
                                Console.WriteLine(Math.Round(a) + " Dias");
                                a = a - a;
                            }
                            break;

                        //36 Numeros primos
                        case 36:
                            Console.Write("\t\t\t************** 36 Encontrar mayor ****************\n\n");
                            Console.Write("\nPor favor ingrese un numero: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\nPor favor ingrese un numero: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            if (a > b)
                            {
                                Console.WriteLine("El numero mayor es " + a);

                            }
                            else
                            {
                                Console.WriteLine("El numero mayor es " + b);
                            }
                            break;

                        //37 Ordenar de mayor a menor
                        case 37:
                            Console.Write("\t\t\t **************** 37 Ordenar de mayor a menor *******************\n\n");
                            Console.Write("\n ingrese 2 numeros: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nIngresar el numero: ");
                            b = Convert.ToInt32(Console.ReadLine());
                            if (a > b)
                            {
                                Console.WriteLine("El numero mayor es " + a);
                                Console.WriteLine("El numero menor es " + b );

                            }
                            else
                            {
                                Console.WriteLine("El numero mayor es " + b);
                                Console.WriteLine("El numero menor es " + a);

                            }
                            break;

                        //38 factorial de un numero
                        case 38:
                            Console.Write("\t\t\t ***************** 38 Factorial de un numero **********************\n\n");
                            Console.Write("\nPor favor ingrese un numero: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            i = 1;
                            factorial = 1;
                            while (i <= a)
                            {
                                factorial = factorial * i;
                                i = i + 1;
                            }
                            Console.Write((factorial));
                            break;


                        case 70:
                            return;
                        default:
                            Console.WriteLine("Inserte un valor correcto para  menu");
                            break;
                    }
                }
                else
                {
                    opcion = 0;
                    Console.WriteLine("El valor Ingresado no es correcto");
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 70);



            Console.ReadKey();
        }
    }
}
