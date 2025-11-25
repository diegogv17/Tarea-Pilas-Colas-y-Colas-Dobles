using Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Colas;
using Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Deque;
using Tarea_Pilas__Colas_y_Colas_Dobles.Estructuras.Pilas;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===== PILAS (STACKS) =====\n");

        EjecutarPila_Ventanas();
        EjecutarPila_Movimientos();

        Console.WriteLine("\n===== COLAS (QUEUES) =====\n");

        EjecutarCola_Restaurante();
        EjecutarCola_Paquetes();

        Console.WriteLine("\n===== DEQUE (COLA DOBLE) =====\n");

        EjecutarDeque_Imagenes();
        EjecutarDeque_Vehiculos();

        Console.WriteLine("\n\nFIN DE TODAS LAS PRUEBAS.");
    }

   
    //  PILAS - EJERCICIO 1

    static void EjecutarPila_Ventanas()
    {
        Console.WriteLine(">>> Ejercicio 1 — Historial de Ventanas Activas");

        Pila<Ventana> pila = new Pila<Ventana>();

        pila.Push(new Ventana("Inicio", "Diego"));
        pila.Push(new Ventana("Configuración", "Diego"));
        pila.Push(new Ventana("Reportes", "Diego"));
        pila.Push(new Ventana("Perfil", "Diego"));
        pila.Push(new Ventana("Ayuda", "Diego"));
        pila.Push(new Ventana("Usuarios", "Diego"));

        Console.WriteLine($"Ventana activa: {pila.Peek()}");

        Console.WriteLine("\nCerrando 3 ventanas...");
        for (int i = 0; i < 3; i++)
        {
            var cerrada = pila.Pop();
            Console.WriteLine($"Cerrada: {cerrada}");
            Console.WriteLine($"Ahora activa: {pila.Peek()}");
        }

        Console.WriteLine($"\nVentanas restantes: {pila.Count}\n");
    }


    //  PILAS - EJERCICIO 2

    static void EjecutarPila_Movimientos()
    {
        Console.WriteLine(">>> Ejercicio 2 — Undo Moves del Juego");

        Pila<Movimiento> pila = new Pila<Movimiento>();

        pila.Push(new Movimiento("Saltar", "x=3,y=1", 10));
        pila.Push(new Movimiento("Mover", "x=4,y=1", 12));
        pila.Push(new Movimiento("Atacar", "x=4,y=2", 15));
        pila.Push(new Movimiento("Mover", "x=5,y=2", 18));
        pila.Push(new Movimiento("Saltar", "x=5,y=3", 21));
        pila.Push(new Movimiento("Mover", "x=6,y=3", 25));
        pila.Push(new Movimiento("Atacar", "x=6,y=4", 30));
        pila.Push(new Movimiento("Mover", "x=7,y=4", 33));

        Console.WriteLine($"Movimiento actual: {pila.Peek()}");

        Console.WriteLine("\nHaciendo 4 undo...");
        for (int i = 0; i < 4; i++)
        {
            var borrado = pila.Pop();
            Console.WriteLine($"Deshecho: {borrado}");
            Console.WriteLine($"Movimiento actual ahora: {pila.Peek()}");
        }

        Console.WriteLine($"\nMovimientos restantes: {pila.Count}\n");
    }


    //  COLAS - EJERCICIO 1
    static void EjecutarCola_Restaurante()
    {
        Console.WriteLine(">>> Ejercicio 1 — Cola en Restaurante");

        Cola<Cliente> cola = new Cola<Cliente>();

        cola.Enqueue(new Cliente(1, "Carlos", "Desayuno"));
        cola.Enqueue(new Cliente(2, "Ana", "Almuerzo"));
        cola.Enqueue(new Cliente(3, "Luis", "Cena"));
        cola.Enqueue(new Cliente(4, "Maria", "Almuerzo"));
        cola.Enqueue(new Cliente(5, "Jose", "Cena"));
        cola.Enqueue(new Cliente(6, "Pedro", "Desayuno"));
        cola.Enqueue(new Cliente(7, "Lucía", "Cena"));
        cola.Enqueue(new Cliente(8, "Sofia", "Almuerzo"));
        cola.Enqueue(new Cliente(9, "Miguel", "Desayuno"));

        Console.WriteLine("\nAtendiendo 4 clientes...");
        for (int i = 0; i < 4; i++)
        {
            var atendido = cola.Dequeue();
            Console.WriteLine($"Atendido: {atendido}");
        }

        Console.WriteLine($"\nSiguiente en fila: {cola.Peek()}");
        Console.WriteLine($"Clientes restantes: {cola.Count}\n");
    }

    //  COLAS - EJERCICIO 2

    static void EjecutarCola_Paquetes()
    {
        Console.WriteLine(">>> Ejercicio 2 — Control de Paquetes");

        Cola<Paquete> cola = new Cola<Paquete>();

        cola.Enqueue(new Paquete("PK01", "Amazon", 2.5));
        cola.Enqueue(new Paquete("PK02", "FedEx", 1.2));
        cola.Enqueue(new Paquete("PK03", "UPS", 4.3));
        cola.Enqueue(new Paquete("PK04", "Alibaba", 3.8));
        cola.Enqueue(new Paquete("PK05", "DHL", 2.0));
        cola.Enqueue(new Paquete("PK06", "eBay", 1.7));
        cola.Enqueue(new Paquete("PK07", "MercadoLibre", 5.1));

        Console.WriteLine("\nProcesando 3 paquetes...");
        for (int i = 0; i < 3; i++)
        {
            var procesado = cola.Dequeue();
            Console.WriteLine($"Procesado: {procesado}");
        }

        Console.WriteLine($"\nPróximo paquete: {cola.Peek()}");

        double pesoPendiente = 0;
        Cola<Paquete> aux = cola;

        // Calcular peso pendiente
        NodoCola<Paquete> temp = typeof(Cola<Paquete>)
            .GetField("frente", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            .GetValue(aux) as NodoCola<Paquete>;

        while (temp != null)
        {
            pesoPendiente += temp.Valor.Peso;
            temp = temp.Siguiente;
        }

        Console.WriteLine($"Peso total pendiente: {pesoPendiente} kg\n");
    }

 
    //  DEQUE - EJERCICIO 1
    static void EjecutarDeque_Imagenes()
    {
        Console.WriteLine(">>> Ejercicio 1 — Navegación de Imágenes");

        Deque<Imagen> deque = new Deque<Imagen>();

        deque.InsertRear(new Imagen("foto1.jpg", "1080p", DateTime.Today));
        deque.InsertRear(new Imagen("foto2.jpg", "4K", DateTime.Today));
        deque.InsertRear(new Imagen("foto3.jpg", "720p", DateTime.Today));
        deque.InsertRear(new Imagen("foto4.jpg", "8K", DateTime.Today));
        deque.InsertRear(new Imagen("foto5.jpg", "1080p", DateTime.Today));

        Console.WriteLine("\nMoviendo 2 veces a la izquierda (DeleteFront)...");
        for (int i = 0; i < 2; i++)
        {
            var eliminado = deque.DeleteFront();
            Console.WriteLine($"Desplazado: {eliminado}");
            Console.WriteLine($"Actual: {deque.PeekFront()}");
        }

        Console.WriteLine("\nInsertando nueva imagen al inicio...");
        deque.InsertFront(new Imagen("nueva.jpg", "4K", DateTime.Today));

        Console.WriteLine($"Actual: {deque.PeekFront()}\n");
    }


    //  DEQUE - EJERCICIO 2

    static void EjecutarDeque_Vehiculos()
    {
        Console.WriteLine(">>> Ejercicio 2 — Carril Reversible");

        Deque<Vehiculo> deque = new Deque<Vehiculo>();

        deque.InsertFront(new Vehiculo("P001", "Automóvil"));
        deque.InsertRear(new Vehiculo("P002", "Camión"));
        deque.InsertFront(new Vehiculo("P003", "Moto"));
        deque.InsertRear(new Vehiculo("P004", "Automóvil"));
        deque.InsertFront(new Vehiculo("P005", "Camión"));

        Console.WriteLine("\nProcesando 3 vehículos desde el frente...");
        for (int i = 0; i < 3; i++)
        {
            var veh = deque.DeleteFront();
            Console.WriteLine($"Salida: {veh}");
        }

        Console.WriteLine("\nInsertando 2 por atrás...");
        deque.InsertRear(new Vehiculo("P006", "Moto"));
        deque.InsertRear(new Vehiculo("P007", "Automóvil"));

        Console.WriteLine($"Vehículos restantes: {deque.Count}\n");
    }
}

  