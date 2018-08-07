
function apagarElemento()
{
    if (document.contains(document.getElementById(id)))
    {
        document.getElementById(id).remove();
    }
}

function apagarElementoDeValidacao() {
    apagarElemento("span-campo-nome-menor-10");
    apagarElemento("span-campo-nome-maior-100")
}

function validarFormulario() {
    var textoCampoNome = document.getElementById("campo-nome").value;
    var textoCapoCPF = document.getElementById("campo-cpf").value;
    var textoCampoSalario = document.getElementById("campo-salario").value;
    var textoCampoTempoEmpresa = document.getElementById("campo-tempo-empresa").value;

    apagarElementoDeValidacao();

   
    if (textoCampoNome.lenght < 10) {
        

            var elementoSpanNome = document.createElement("span");
            var texto = document.createTextNode("Campo nome deve ter no mínimo 10 caracteres");
            elementoSpanNome.id = "span-campo-nome-menor-10";
            elementoSpanNome.appendChild(texto);
            elementoSpanNome.classList.add("text-danger");
            document.getElementById("div-campo-nome").appendChild(elementoSpanNome);
            document.getElementById("campo-nome").classList.add("border-danger");
        
    }

    if (textoCampoNome.lenght > 100) {

        elementoSpanNome = document.createElement("span");
        var texto = document.createTextNode("Campo nome deve ter no máximo 100 caracteres");
        elementoSpanNome.id = "span-campo-nome-maior-100";
        elementoSpanNome.appendChild(texto);
        elementoSpanNome.classList.add("text-danger");
        document.getElementById("div-campo-nome").appendChild(elementoSpanNome);
        document.getElementById("campo-nome").classList.add("border-danger");


    }

    /*var quantidadeCaractereCampoCPF = textoCapoCPF.lenght;
    if (quantidadeCaractereCampoCPF < 15) {
        alert("Campo de CPF deve conter 16 dígitos");

    }
    var salario = parseFloat(textoCampoSalario);
    if (salario < 1200) {
        alert("Salário deve ser maior que 1200");
    }
    else if (salario > 100000) {
        alert("Salário não pode ultrapassar 100000");
    }*/
    
}