function validarFormulario() {
    var textoCampoNome = document.getElementById("campo-nome").value;
    var textoCapoCPF = document.getElementById("campo-cpf").value;
    var textoCampoEmpresa = document.getElementById("campo-tempo-empresa").value;

    var quantidaddeCaracteresCampoNome = textoCampoNome.lenght;
    console.log("Texto: " + quantidaddeCaracteresCampoNome)
    console.log("Quantidade: " + textoCampoNome);

    if (quantidaddeCaracteresCampoNome > 10 || quantidaddeCaracteresCampoNome < 100) {
        alert("Campo nome deve ter no mínimo 10 caracteres e no máximo 100 caracteres");
    }
}