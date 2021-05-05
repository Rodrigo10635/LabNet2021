
document.getElementById("limpiar").addEventListener("click", function () {
    document.getElementById("nombre").value = "";
    document.getElementById("apellido").value = "";
    document.getElementById("edad").value = "";
    document.getElementById("empresa").value = "";


});
document.getElementById("enviar").addEventListener("click", function () {

    var nombre = document.getElementById('nombre')
    var apellido = document.getElementById('apellido')

    if (nombre.value == "") {
        alert("Debe completar el campo nombre")
    }
    if (apellido.value == "") {
        alert("Debe completar el campo apellido")
    }
})