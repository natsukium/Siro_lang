module Siro

let convertTable =
    Map [ ">", "こいつはひでえや！"
          "<", "なんて日だ！"
          "+", "🐬"
          "-", "おほー！"
          ".", "いいねいいねぇ！"
          ",", "AKMだ！"
          "[", "おしり！"
          "]", "いつものー！" ]

let convert (code : string) =
    let token = [ ">"; "<"; "+"; "-"; "."; ","; "["; "]" ]

    let rec loop (code : string) token =
        match token with
        | [] -> code
        | key :: token ->
            let c = code.Replace(convertTable.[key], key)
            loop c token
    loop code token
