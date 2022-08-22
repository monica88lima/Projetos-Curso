var hr = 0;
var mi = 0;
var se = 0;
var tempo = 1000;


function play() {
    cron = setInterval(timer, tempo);
    
}

function parar() {
    clearInterval(cron)
    
    
}
function zerar() {
    clearInterval(cron)
    
    hr = 0;
    mi = 0;
    se = 0;
    
    document.getElementById('contador').innerText = '00:00:00'
    
}
function timer() {
    se++
   
    if (se == 60) {
        se = 0
        mi++
        if (mi == 60) {
            mi = 0
            hr++
           
        }
    }
    var form = (hr < 10 ? '0' + hr : hr) + ':' + (mi < 10 ? '0' + mi : mi) + ':' +(se < 10 ? '0' + se : se)
    
    document.getElementById('contador').innerText = form
        
}
function agora(){
    console.log=('1')
    var relogio= document.getElementById('horarioAtual')
    console.log=('2')
    var data= new Date()
    console.log=('3')
    var hora = data.getHours()
    console.log=('4')
    var minu = data.getMinutes()
    console.log=('5')


    relogio.innerHTML = `<strong>${hora}</strong>:<strong>${minu}</strong>`
}

