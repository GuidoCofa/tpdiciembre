// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function mostrarListaTorneos(torneos) {
    const listaTorneosElement = document.getElementById("listaTorneos");


    listaTorneosElement.innerHTML = '';


    torneos.forEach(torneo => {
        const listItem = document.createElement('li');
        listItem.textContent = torneo.nombre; 
        listaTorneosElement.appendChild(listItem);
    });
}

    function MostrarTorneos(id){
        $.ajax({
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarTorneos',
            data: {idEquipo: id},
            success:
                function (response){
                    console.log(response);
                    
                    alert(
                        response.nombreTorneo );
                }
        });
    }

