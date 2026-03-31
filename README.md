1. Kiedy Git wykonuje fast‑forward, a kiedy powstaje merge commit?
Fast‑forward wykonuje się wtedy, gdy na gałęzi main nie pojawiły się żadne nowe commity od momentu utworzenia drugiej gałęzi.
W takiej sytuacji Git po prostu przesuwa main do przodu i nie tworzy dodatkowego commita.
Merge commit powstaje wtedy, gdy zarówno na main, jak i na drugiej gałęzi zostały wprowadzone zmiany i Git musi połączyć dwie niezależne.

2. Czym w praktyce różni się merge od rebase?
Merge zachowuje pełną historię pracy i dodaje osobny commit łączący gałęzie, przez co w historii widać rozgałęzienia.
Rebase przepisuje historię tak, jakby zmiany z gałęzi zostały wykonane bezpośrednio na main, dzięki czemu historia jest czytelniejsza.

3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
Konflikt został wywołany celowo poprzez zmianę tego samego fragmentu kodu na dwóch gałęziach.
Podczas rozwiązywania konfliktu ręcznie usunąłem znaczniki konfliktu i wybrałem finalną wersję kodu.

Poniżej zrzut ekreany wyniku komendy 'git log --oneline --graph --all"
<img width="860" height="598" alt="image" src="https://github.com/user-attachments/assets/36dd4e1f-f296-407c-b822-34e90ed8ebdb" />
