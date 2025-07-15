function calcula()
{
var m1 = document.getElementById("multiplicando"),
        m2 = document.getElementById("multiplicador"),
  p1 = document.getElementById("producto");
p1.value = parseFloat(m1.value) * parseFloat(m2.value);
}