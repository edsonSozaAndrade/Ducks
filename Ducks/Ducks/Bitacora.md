## Cambios Existentes ##
* La herencia da rigidez a las clases de modo que estas heredan todos los comportamientos as� no sean los requeridos o implementados
* Las interfaces parec�an ser una buena soluc�on, pero un override de sus comportamientos en cuanto la aplicaci�n crezca traer�a muchos problemas
* Por ello se separan en behaviors que tienen la funcionalidad de comportarse como interfaces que seran a�adidas a la clase optando a la composici�n como una mejor
alternativa frente a la herencia
* Componer la clase Duck de behaviors hace m�s entendible y f�cil de reusar los comportamientos de acuerdo a la agrupaci�n de sus caracter�sticas ya sea al momento de 
volar o de hacer quack
* Sin embargo al tener comportamientos que si o si son inherentes a la clase se la mantiene abstracta junto al m�todo display que se sabe todas las clases lo implementar�n
