function validarFormulario() {
    var textoCampoNome = document.getElementById("campo-nome").value;
    var textoCapoCPF = document.getElementById("campo-cpf").value;
    var textoCampoEmpresa = document.getElementById("campo-tempo-empresa").value;
    var textoCampoSalario = document.getElementById("campo-salario").value;

    var quantidaddeCaracteresCampoNome = textoCampoNome.lenght;
    console.log("Texto: " + quantidaddeCaracteresCampoNome)
    console.log("Quantidade: " + textoCampoNome);

    if (quantidaddeCaracteresCampoNome > 10 || quantidaddeCaracteresCampoNome < 100) {
        alert("Campo nome deve ter no mínimo 10 caracteres e no máximo 100 caracteres");
    }

    var quantidadeCaractereCampoCPF = textoCapoCPF.lenght;
    if (quantidadeCaractereCampoCPF < 15) {
        alert("Campo de CPF deve conter 16 dígitos");

    }
    var salario = parseFloat(textoCampoSalario);
    if (salario < 1200) {
        alert("Salário deve ser maior que 1200");
    }
    else if (salario > 100000) {
        alert("Salário não pode ultrapassar 100000");
    }
    
}