Ejercicio N° 8
Desarrollo de software
Herencia y propiedades
Realizar una bifurcación (fork) del repositorio
Crear una rama de larga duración desarrollo
Clonar el repositorio bifurcado y trabajar sobre la rama development
Refactorizar el código aplicando herencia según el caso
Reemplazar los métodos getters y setters, y campos por propiedades, tener en cuenta la accesibilidad en cada caso
Respetar que al crear una cuenta bancaria se recibirá el número y el saldo en el constructor
La tasa de interés se debe indicar al inicializar la instancia de cuenta, pero no mediante el constructor.
El límite de descubierto se debe indicar al inicializar la instancia de cuenta, pero no mediante el constructor.
Agregar las siguientes reglas:
El monto recibido por cualquier operación no puede ser menor o igual a 0, de lo contrario generará una excepción del tipo MontoNoValido
Cualquier operación se debe realizar si la cuenta está activa, en cualquier otro caso generar una excepción del tipo CuentaNoActiva
Se debe contar con saldo para realizar un retiro, caso contrario debe generar una excepción Saldo Insuficiente y la cuenta debe quedar suspendida. Tener en cuenta el límite de descubierto si corresponde
Instanciar 4 cuentas (dos de cada tipo) y realizar diferentes operaciones que permitan comprobar todas las funciones posibles.
Registre las 4 cuentas creadas y muestre por consola un resumen de cada una, que incluya número, tipo y saldo (utilizar una clase anónima)
Consideraciones:

Las excepciones deben incluir los siguientes mensajes:
MontoNoValido -> El monto ingresado no es válido para la operación solicitada
CuentaNoActiva -> No se puede operar con la cuenta {estado} (reemplazar por el estado en el que se encuentra)
SaldoInsuficiente -> La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.
La aplicación no debe interrumpir su funcionamiento si se produce una excepción.
