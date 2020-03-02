// Learn more about F# at http://fsharp.org

open System

module Morze =

    (*let translate (text : string) =
        let chars : char [] = text.ToCharArray
        let mutable charr = ""
        for idx = 0 to text.Length - 1 do
            let mutable charss = chars.[idx]


            //let mutable charr =  text.[i]
            //match text.[i] with
            charss
    *)

    let translateSymbol char = 
        match char with
        | 'а' | 'a' -> ".-"
        | 'б' | 'b' -> "-..."
        | 'в' | 'w' -> ".--"
        | 'г' | 'g' -> "--."
        | 'д' | 'd' -> "-.."
        | 'е' | 'e' -> "."
        | 'ж' | 'v' -> "...-"
        | 'з' | 'z' -> "--.."
        | 'и' | 'i' -> ".."
        | 'й' | 'j' -> ".---"
        | 'к' | 'k' -> "-.-"
        | 'л' | 'l' -> ".-.."
        | 'м' | 'm' -> "--"
        | 'н' | 'n' -> "-."
        | 'о' | 'o' -> "---"
        | 'п' | 'p' -> ".--."
        | 'р' | 'r' -> ".-."
        | 'с' | 's' -> "..."
        | 'т' | 't' -> "-"
        | 'у' | 'u' -> "..-"
        | 'ф' | 'f' -> "..-."
        | 'х' | 'h' -> "...."
        | 'ц' | 'c' -> "-.-."
        | 'ч' -> "---."
        | 'ш' -> "----"
        | 'щ' | 'q' -> "--.-"
        | 'ъ' | 'x' -> ".--.-."
        | 'ы' | 'y' -> "-.--"
        | 'ь' -> "-..-"
        | 'э' -> "..-.."
        | 'ю' -> "..--"
        | 'я' -> ".-.-"
        | ' ' -> " "
        |'1' -> ".----"
        |'2' -> "..---"
        |'3' -> "...--"
        |'4' -> "....-"
        |'5' -> "....."
        |'6' -> "-...."
        |'7' -> "--..."
        |'8' -> "---.."
        |'9' -> "----."
        |'0' -> "-----"
        |',' -> ".-.-.-"
        |'.' -> "......"
        |';' -> "-.-.-."
        |':' -> "---..."
        |'?' -> "..--.."
        |'!' -> "--..--"
        |'"' -> ".-..-."
        |''' -> ".----."
        |'(' | ')' -> "-.--.-"
        |'/' -> "-..-."
        |'-' -> "-....-"
        |'@' -> ".--.-."
        |'=' -> "-...-"
        |'+' -> ".-.-."
        |'$' -> "...-..-"
        | _ -> "Неправильно введён символ"
    let translate (text : string) =
        let symbols = text.ToLower().ToCharArray()
        let mutable resultText = ""
        for symbol in symbols do
            resultText <- resultText + translateSymbol symbol
        resultText


    [<EntryPoint>]
    let main argv =
        while true do
            let text = Console.ReadLine()
            printfn "%s" (translate text)
        Console.ReadKey |> ignore
        0 // return an integer exit code
