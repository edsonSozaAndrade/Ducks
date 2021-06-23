## Cambios Existentes ##
* La herencia da rigidez a las clases de modo que estas heredan todos los comportamientos así no sean los requeridos o implementados
* Las interfaces parecían ser una buena solucíon, pero un override de sus comportamientos en cuanto la aplicación crezca traería muchos problemas
* Por ello se separan en behaviors que tienen la funcionalidad de comportarse como interfaces que seran añadidas a la clase optando a la composición como una mejor
alternativa frente a la herencia
* Componer la clase Duck de behaviors hace más entendible y fácil de reusar los comportamientos de acuerdo a la agrupación de sus características ya sea al momento de 
volar o de hacer quack
* Sin embargo al tener comportamientos que si o si son inherentes a la clase se la mantiene abstracta junto al método display que se sabe todas las clases lo implementarán
