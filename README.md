Es un gusto estar participando en este proceso de selección, el connection string se configura en un archivo .txt que está en la carpeta del proyecto TestCrud. 

el proyecto está estructurado en tres capas, y va orientado a implementar la responsabilidad única en cada clase o modelo,, 

Por falta de tiempo debido a que actualmente laboro en una empresa local, me faltó que afinar muchos detalles , lo que yo hubiese agregado es un manejador de 
errores estructurado,crear una tabla que guarde todas las excepciones, las excepciones de toda la solución las tomaría de HttpContext.Features.Get<IExceptionHandlerPathFeature>(); luego
las guardaría en una tabla en la base de datos, a través de dicha interface yo puedo obtener el path exacto en donde está ocurriendo el error, aparte un StackTrace,
en el puedo visualizar más detalles de la excepción que se generó, 

también me faltó terminar de estructurar la capa de dominio, ya que ejecuto las acciones desde los modelos, lo correcto debería ser desde repositorios que luego pueden ser
consultados desde los controladores. 

En resumen el proyecto está estructurado a que en cierto punto haya poca redundancia de código , que sea escalable y que cada componente tenga responsabilidad única.



