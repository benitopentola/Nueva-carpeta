open System

let rnd = new Random()
let secretNumber = rnd.Next(1, 101)
let mutable guess = 0

printfn "Adivina el número secreto (entre 1 y 100): "

while guess <> secretNumber do
    let input = Console.ReadLine()
    let success, parsedGuess = Int32.TryParse(input)
    if success then
        guess <- parsedGuess
        if guess < secretNumber then
            printfn "El número es más alto."
        elif guess > secretNumber then
            printfn "El número es más bajo."
        else
            printfn "¡Felicidades, has adivinado el número secreto!"
    else
        printfn "Por favor ingrese un número válido."

printfn "Fin del juego."
