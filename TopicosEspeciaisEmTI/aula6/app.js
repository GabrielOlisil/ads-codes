
const matriz = [];

// 1
let contador = 1;
for (let i = 0; i < 4; i++) {
  matriz.push([]);
  for (let j = 0; j < 4; j++) {
    matriz[i][j] = contador;
    contador++
  }

}
document.writeln();

for (let i = 0; i < 4; i++) {

  document.writeln(matriz[i]);
}

// 2
for (let i = 0; i < 4; i++) {
  for (let j = 0; j < 4; j++) {
    if (matriz[i][j] == 10) {
      document.writeln(`Numero 10 está em (${j}, ${i})`)
    }
  }

}


// 3


let idade = 18;


if (idade > 18) {
  document.writeln("É maior de idade");
}


if (idade < 18) {
  document.writeln("ainda é menor de idade");
}

if (idade == 18) {
  document.writeln("tem dezoito anos");
}

if (idade != 0) {
  document.writeln("não é mais recém nascido");
}

if (idade === "18") {
  document.writeln("variavel idade tem valor 18 e tipo string");
}


if (idade !== "18") {
  document.writeln("idade não tem tipo string, porém tem valor 18");
}

if (idade >= 60) {
  document.writeln("está na terceira idade");
}


if (idade <= 17) {
  document.writeln("ainda não pode tirar carteira de habilitação");
}

let temCNH = false;

if (idade >= 18 && temCNH) {
  document.writeln("Pode andar de moto");
}
else {
  document.writeln("Não pode andar de moto");
}


if (idade < 18 || !temCNH) {

  document.writeln("não pode andar de carro");

} else {

  document.writeln("pode andar de carro");
}

