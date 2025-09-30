<!DOCTYPE html>
<html lang="tr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>HTML'de Emoji Örneği</title>
    <style>
        .emoji {
            font-size: 3em; /* Emojileri daha görünür yapmak için */
            line-height: 1.5;
        }
    </style>
</head>
<body>

    <h1>HTML'de Emoji Kullanma</h1>

    <h2>1. Doğrudan Kopyala-Yapıştır</h2>
    <p>Bu en basit ve en çok önerilen yoldur. Emojiyi (örneğin bir klavyeden veya web sitesinden) kopyalayıp doğrudan HTML içine yapıştırırsın.</p>
    <div class="emoji">
        Merhaba Dünya! ✨🎉🚀
    </div>
    
    <h2>2. HTML Varlık Kodları Kullanımı</h2>
    <p>Eski sistemlerde veya belirli durumlarda kullanışlıdır, ancak doğrudan yapıştırmak genellikle daha kolaydır.</p>
    
    <h3>Ondalık Varlık Örnekleri (&#NNNNN;)</h3>
    <div class="emoji">
        Kalp: &#10084; <br> 
        Güneş: &#9728; <br>
        Gülümseme: &#128515;
    </div>
    
    <h3>Onaltılık Varlık Örnekleri (&#xXXXX;)</h3>
    <div class="emoji">
        Kalp: &#x2764; <br>
        Güneş: &#x2600; <br>
        Gülümseme: &#x1F603;
    </div>

</body>
</html>
