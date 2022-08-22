function tabuada() {
    let multiplicador = document.getElementById('txttab')
    let base = 1
    let result = document.getElementById('seltab')
    console.log('teste1')
    if (multiplicador.value.length == " ") {
        alert("ERRO!Digite um número!")
        console.log('teste2')
    } else {
        console.log('teste3')
        let n = Number(multiplicador.value)
        result.innerHTML = ' '
        console.log('teste4')
        while (base <= 10) {
            r = n * base
            let item = document.createElement('option')
            item.text = `${n} x ${base} = ${r} `
            result.appendChild(item)
            console.log('teste5')
            base++
        }
        // for(r = n*base ; base <=10 ; base++)


    }
}
