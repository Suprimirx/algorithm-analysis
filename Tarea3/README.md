## Ejercicios Resueltos — Tarea 3: Grafos
 
### 1. [547. Number of Provinces](https://leetcode.com/problems/number-of-provinces/)
 
* **Dificultad:** Medium
* **Código de la solución:** [Ver implementación en el repositorio](./number-of-provinces/NumberOfProvinces.cs)
#### Modelo
El grafo es **no dirigido**: cada ciudad `i` (de `0` a `n-1`) es un **vértice**, y existe una **arista** entre `i` y `j` cuando `isConnected[i][j] == 1` con `i ≠ j` (la diagonal no cuenta como arista, es la ciudad conectada consigo misma por definición). Una **provincia** es exactamente una **componente conexa** de este grafo: un grupo de ciudades donde, directa o indirectamente, se puede llegar de cualquiera a cualquiera.
 
#### Algoritmo Utilizado y Justificación
Se utilizó **DFS (Depth-First Search)** para marcar componentes conexas.
* **Por qué esta familia:** el problema no pide un orden ni un camino más corto, solo agrupar vértices alcanzables entre sí. Un recorrido en profundidad es la forma más directa de "propagar" desde una ciudad no visitada hacia todas las que están conectadas con ella, sin estructuras auxiliares más allá de un arreglo de visitados.
* **Estrategia:** se recorre cada ciudad de `0` a `n-1`; cada vez que se encuentra una ciudad **no visitada**, se suma 1 al contador de provincias y se lanza un DFS que marca como visitadas todas las ciudades alcanzables desde ahí. Al terminar el recorrido externo, el contador refleja el número total de componentes conexas.
#### Complejidad
* **Complejidad de Tiempo:** **O(n²)**, donde `n` es el número de ciudades. La entrada ya es una matriz `n × n`, así que en el peor caso el DFS termina revisando cada una de las `n²` celdas de la matriz.
* **Complejidad de Espacio:** **O(n)** de espacio auxiliar, para el arreglo `visitado` más la pila de recursión del DFS (en el peor caso, una cadena de `n` ciudades conectadas entre sí).
#### Evidencia de Éxito (Accepted)
A continuación se presenta el enlace relativo a la captura de pantalla que demuestra que la solución fue aceptada en LeetCode de manera exitosa:
 
![Evidencia de éxito para Number of Provinces](./evidencias/number-of-provinces-accepted.jpeg)
 
---