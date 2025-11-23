# 🧙‍♂️ CodeQuestDLC – Text RPG en C#

**CodeQuestDLC** és un RPG de consola fet en **C#**, on assumes el paper d’un aprenent de mag i avances per diferents capítols: entrenament, combats, mineria, compres, atacs màgics i descodificació de pergamins ancestrals.

El joc combina humor, fantasia i tocs de programació per crear una aventura lleugera però plena de mecàniques.

---

## 🎮 Menú principal

Des del menú pots accedir a totes les funcions del joc:

1. **Train your wizard**
2. **Increase LVL (combat contra un monstre)**
3. **Loot the mine**
4. **Show inventory**
5. **Buy items**
6. **Show attacks by LVL**
7. **Decode ancient scroll (Nou!)**
0. **Exit game**

Cada opció forma part d’un “capítol” del joc.

---

## 📜 Capítol 1 – Entrenament del mag

- Introdueixes el **nom** del mag.
- Entrenes durant **5 dies**, obtenint hores i experiència aleatòries.
- Segons la teva experiència final, reps un **títol especial**:

| Exp     | Títol                 |
|---------|-----------------------|
| `< 20`  | Raoden el Elantrí     |
| `20–29` | Zyn el Buguejat       |
| `30–34` | Arka Nullpointer      |
| `35–39` | Elarion de les Brases |
| `≥ 40`  | ITB-Wizard el Gris    |

---

## 🐉 Capítol 2 – Increase LVL (Combat)

- Entres en combat contra un enemic aleatori.
- El monstre té vida diferent segons el tipus.
- Llança un **dau ASCII** (1–6) i li vas restant vida.
- Al derrotar-lo, puges de nivell (nivell màxim 5).

Enemics inclouen: Skeleton, Goblin, Slime, Ember Wolf, Spider, Golem, Necromancer i Ancient Dragon.

---

## ⛏️ Capítol 3 – Loot the mine

- Mapa 5×5 generat aleatòriament amb caselles buides o monedes.
- Tens **5 intents** per excavar.
- Si encertes, guanyes entre **1 i 50 bits**.
- El mapa s’actualitza visualment amb símbols: `🪙`, `❌`, `➖`.
- Al final, reps els bits totals obtinguts.

---

## 🎒 Capítol 4 – Inventari

Llista tot el que has comprat.  
L’inventari creix dinàmicament amb `Array.Resize()`.

---

## 🛒 Capítol 5 – Botiga

Pots comprar:

- Iron Dagger
- Healing Potion
- Ancient Key
- Crossbow
- Metal Shield

Cada ítem té un preu específic.  
Si tens prou bits, s’afegeix a l’inventari.

---

## 🔥 Capítol 6 – Atacs per nivell

El joc inclou un **jagged array** d’atacs màgics per nivell:

- Nivell 1: Magic Spark
- Nivell 2: Fireball, Ice Ray, Arcane Shield
- Nivell 3 i superiors: encanteris més poderosos

Quan mostres atacs, el joc imprimeix només fins al teu nivell actual.

---

## 🧾 Capítol 7 – Decode Ancient Scroll (Nou!)

Un pergamí misteriós amb tres línies màgiques. Pots:

1. **Eliminar espais**
2. **Comptar runes màgiques (vocals)**
3. **Extreure el codi secret (nombres)**

Quan descodifiques les tres parts, reps un missatge especial.

---

## ⚙️ Detalls tècnics

- **Llenguatge:** C#
- **Tipus:** App de consola
- **Ús intensiu de:**
    - constants per textos
    - arrays i jagged arrays
    - gràfics ASCII
    - mapa bidimensional
    - validació amb `int.TryParse()`
    - `Random` per generar esdeveniments dinàmics
- Estructurat per capítols en un `switch(menuOption)`.

---

## 🧠 Què pots practicar amb aquest projecte

- Control de flux (`do…while`, `for`, `switch`)
- Validació d’input
- Treballar amb arrays multidimensionals i jagged arrays
- Simulació d’esdeveniments aleatoris
- Disseny bàsic d’un RPG per consola
- Gestió de l’estat del jugador i inventari

---

## 🚀 Execució

Compila i executa amb:
```bash
dotnet run
```

I gaudeix de l’aventura.