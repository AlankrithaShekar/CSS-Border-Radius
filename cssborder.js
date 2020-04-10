      function convert()
{
    var x =document.getElementById('b-top').value;
    document.documentElement.style.setProperty('--valuet',x+'px');
    var y = document.getElementById('b-left').value;
    document.documentElement.style.setProperty('--valuel',y+'px');
    var z = document.getElementById('b-bottom').value;
    document.documentElement.style.setProperty('--valueb',z+'px');
    var w = document.getElementById('b-right').value;
    document.documentElement.style.setProperty('--valuer',w+'px');
   

    return true;
}
