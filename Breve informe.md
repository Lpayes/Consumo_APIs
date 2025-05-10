# Breve Informe  

## ¿Qué API(s) usaste?  
Para esta tarea utilicé dos APIs principales:  
- **PokeAPI:** Esta API me permitió obtener información detallada sobre Pokémon, como su nombre, altura, peso e imagen.  
- **TheCatAPI:** Esta API proporcionó datos sobre las razas de gatos, incluyendo su nombre, origen, temperamento e imágenes.  

---

## ¿Qué dificultades encontraste y cómo las resolviste?  

- **Dificultad al Configurar el Encabezado de la API Key:**  
  - **Problema:** Configuraba el encabezado de la API Key (`x-api-key`) en cada solicitud, lo cual era ineficiente y generaba errores.  
  - **Solución:** Moví la configuración del encabezado al método `Form1_Load`, garantizando que solo se establezca una vez.  

- **Problemas con el Guardado de Datos en JSON:**  
  - **Problema:** El guardado inicial sobrescribía el archivo JSON en cada guardado.  
  - **Solución:** Ajusté el código para que lea el archivo JSON existente y agregue nuevos datos a una lista antes de guardar.  

- **Manejo de Errores en las Solicitudes HTTP:**  
  - **Problema:** En ocasiones, las solicitudes a las APIs fallaban y provocaban excepciones.  
  - **Solución:** Implementé bloques `try-catch` para manejar errores de red o de respuesta del servidor, mostrando mensajes claros al usuario.  

- **Optimización de Imágenes:**  
  - **Problema:** El programa mostraba imágenes incorrectas si la URL no era válida.  
  - **Solución:** Verifiqué que las URLs de las imágenes existieran antes de cargarlas en el formulario.  

---

## ¿Qué aprendiste con esta tarea?  

- A utilizar correctamente `HttpClient` en aplicaciones de Windows Forms.  
- La importancia de establecer configuraciones (como la API Key) de manera eficiente, evitando configurarlas en cada solicitud.  
- A manejar archivos JSON para almacenar datos, garantizando que los nuevos datos se agreguen sin perder los existentes.  
- El uso de bloques `async` y `await` para realizar solicitudes HTTP de forma asíncrona sin bloquear la interfaz de usuario.  
- A diseñar una interfaz intuitiva que permita al usuario buscar y guardar información de manera clara.  

---

## ¿Cómo te apoyaste de la AI para resolver tus dudas?  

- Optimizando el código, separando las funciones de búsqueda, guardado y limpieza de datos, mejorando la estructura del programa.  
- Comprendiendo cómo manejar eficientemente el encabezado de la API Key sin repetir configuraciones.  
- Resolviendo problemas específicos relacionados con la serialización y deserialización de archivos JSON.  
- Mejorando la gestión de errores, mostrando mensajes adecuados al usuario y evitando que el programa se bloquee.  
- Obteniendo recomendaciones para hacer el código más eficiente, claro y mantenible.  
