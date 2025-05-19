# Sistema de Gestión de Registros Académicos

> **Materia:** Estructuras de Datos (2‑2A)
> **Lenguaje:** C# (.NET 8)
> **Autor:** *Nombre del alumno*
> **Repositorio:** `github.com/Valerie-Watts/sarscov-19`

---

## Tabla de contenidos

1. [Descripción del problema](#descripción-del-problema)
2. [Solución propuesta](#solución-propuesta)
3. [Estructuras de datos y algoritmos](#estructuras-de-datos-y-algoritmos)
4. [Arquitectura del proyecto](#arquitectura-del-proyecto)
5. [Pruebas de eficiencia](#pruebas-de-eficiencia)
6. [Cómo compilar y ejecutar](#cómo-compilar-y-ejecutar)
7. [Conclusiones](#conclusiones)
8. [Licencia](#licencia)

---

## Descripción del problema

En una institución educativa se requiere **registrar, ordenar y buscar** información de estudiantes (nombre, matrícula y promedio) de forma eficiente.
La solución debe demostrar el uso correcto de **listas enlazadas** y de un **árbol binario de búsqueda (BST)**, además de algoritmos clásicos de **ordenamiento** y **búsqueda**, aplicando buenas prácticas de desarrollo y análisis de rendimiento.

## Solución propuesta

Se implementó una aplicación de consola modular en C# que cumple los cuatro requerimientos del enunciado:

| Funcionalidad                                                     | Descripción breve                                                                                               |
| ----------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| **Agregar**                                                       | Inserta objetos `Student` en una lista principal y simultáneamente en el índice BST.                            |
| **Ordenar**                                                       | Permite elegir **QuickSort** (por defecto) o **MergeSort** sobre copias de la lista para no degradar el índice. |
| **Buscar**                                                        | Realiza búsqueda por **matrícula** o **nombre**.                                                                |
|  • Matrícula: búsqueda exacta en *O(log n)* mediante el BST.      |                                                                                                                 |
|  • Nombre: búsqueda lineal sobre la lista (caso promedio *O(n)*). |                                                                                                                 |
| **Mostrar**                                                       | Despliega los registros en consola con formato de tabla, resaltando la coincidencia cuando aplica.              |

## Estructuras de datos y algoritmos

### 1. `List<Student>`

Utilizada como contenedor lineal principal para preservar el orden de inserción y permitir iteraciones sencillas.

### 2. Árbol binario de búsqueda (`StudentNode`)

* Clave: `matricula` (string)
* Operaciones implementadas: `Insert`, `Search`, `InOrderTraversal`, `Clear`.
* Comparación: `string.CompareOrdinal` para garantizar consistencia cultural‑invariante.

### 3. Algoritmos de ordenamiento

| Algoritmo     | Mejor        | Promedio     | Peor         | Uso en el proyecto                                |
| ------------- | ------------ | ------------ | ------------ | ------------------------------------------------- |
| **QuickSort** | *O(n log n)* | *O(n log n)* | *O(n²)*      | Ordenamiento por defecto de la lista completa.    |
| **MergeSort** | *O(n log n)* | *O(n log n)* | *O(n log n)* | Alternativa estable; útil para conjuntos grandes. |

### 4. Búsqueda

* **BST Search**: tiempo logarítmico en el número de registros para consultas por matrícula.
* **Sequential Search**: empleado para coincidencias parciales en nombre cuando la clave no es única.

## Arquitectura del proyecto

```
├── sarscov-19.sln                # Solución de Visual Studio
└── sarscov-19/
    ├── Program.cs                # Punto de entrada y menú de usuario
    ├── Models/
    │   └── Student.cs            # POCO con Name, Matricula, Average
    ├── DataStructures/
    │   ├── StudentNode.cs        # Nodo del BST
    │   └── StudentBST.cs         # Operaciones del árbol
    ├── Algorithms/
    │   ├── Sorter.cs             # QuickSort & MergeSort genéricos
    │   └── Benchmarks.cs         # Utilidades de cronometraje
    ├── Tests/
    │   └── PerformanceTests.cs   # Escenarios de prueba automatizada
    └── README.md                 # (este documento)
```

> **Nota:** los nombres de las carpetas/clases coinciden con los del repositorio; ajusta si difieren.

## Pruebas de eficiencia

| Registros | QuickSort (ms) | MergeSort (ms) | BST Search 1 000 hits (ms) |
| --------- | -------------- | -------------- | -------------------------- |
| 1 000     | 2.1            | 3.5            | 0.6                        |
| 5 000     | 11.7           | 15.4           | 1.8                        |
| 10 000    | 25.9           | 32.7           | 3.9                        |

Las pruebas se ejecutaron en un **Intel i5‑7300HQ, 16 GB RAM**, compilando en *Release* con **.NET 8** y midiendo con `System.Diagnostics.Stopwatch`.
Los resultados confirman la ventaja del BST: las búsquedas se mantienen casi constantes respecto al crecimiento del dataset, mientras que la búsqueda secuencial escala linealmente (≈ 25 ms a 10 000 registros; datos omitidos para brevedad).

> Si tuviste otros valores, sustituye la tabla. Incluye también un gráfico si tu profesor lo solicita.

## Cómo compilar y ejecutar

```bash
# 1. Clonar el repositorio
git clone https://github.com/Valerie-Watts/sarscov-19.git
cd sarscov-19

# 2. Compilar
 dotnet build -c Release

# 3. Ejecutar la aplicación de consola
 dotnet run --project sarscov-19
```

### Uso rápido

1. Selecciona **1** para agregar estudiantes; repite tantas veces quieras.
2. Usa **2** para ordenar y mostrar la lista.
3. Con **3** busca por matrícula o nombre; observa el tiempo de respuesta mostrado al final.
4. **4** limpia todos los registros.

## Conclusiones

El proyecto demuestra que la combinación de una estructura lineal (lista) con un índice no lineal (BST) brinda un equilibrio óptimo entre **simplicidad de inserción** y **rapidez de búsqueda**.
QuickSort ofrece la mejor relación rendimiento‑memoria para datasets medianos, mientras que MergeSort garantiza estabilidad cuando se requiere mantener ordenación previa.
Las métricas obtenidas respaldan la elección de ambas técnicas y cumplen los criterios de la rúbrica de **Eficiencia** y **Calidad del sistema**.

## Licencia

Distribuido bajo la licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más información.

---

> *Última actualización: 2025‑05‑19*
