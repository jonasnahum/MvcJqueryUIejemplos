$(function () {
    var estado = false;
    $("#animar").click(function () {
        if (estado) {
            $("#contenido").animate({
                border: "none",
                color: "black",
                width: 600,
                backgroundColor: "white"
            }, 1000);
        }
        else {
            $("#contenido").animate({
                border: "1px solid black",
                color: "red",
                width: 600,
                backgroundColor: "black"
            }, 1000);//duracion.
        }

        estado = !estado;//toggle. cambia estado una vez que sucede el evento click.
    });
})