//@ts-check

let carros = new Array()
let a = 2;

carros[0] = "volvo"
carros[1] = "bmw"

document.writeln(carros.length.toString())

document.writeln(carros[1])

let idade = 20;
let pais = "Brasil"
document.writeln(idade.toString())
document.writeln(pais)

for (let i = 0; i <= 20; i++) {
  if (i % 2 == 0) {
    document.writeln(i + " É par")
  }
  else {
    document.writeln(i + " É impar")
  }
}
