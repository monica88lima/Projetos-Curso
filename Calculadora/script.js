function insert(num){
    let elResultado = document.getElementById('resultado')
    let numero = elResultado.innerHTML
    document.getElementById('resultado').innerHTML = numero + num
    if( numero.length >15){
        alert("A calculadora não suporta a quantidade de caracter digitado!")
    }
 
}
function limpar(){
    document.getElementById('resultado').innerHTML = ""
}
function apagar(){
   let resultado = document.getElementById('resultado').innerHTML
   document.getElementById('resultado').innerHTML = resultado.substring(0, resultado.length -1)
}
function calcular(){
    let resultado = document.getElementById('resultado').innerHTML
    if (resultado) {
        document.getElementById('resultado').innerHTML = eval(resultado)
    } else {
        document.getElementById('resultado').innerHTML = 0
    }

    
}