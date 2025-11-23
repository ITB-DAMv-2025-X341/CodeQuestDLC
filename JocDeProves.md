# 🧙‍♂️ CodeQuestDLC – Plan de Proves Complet

Aquest document conté un **conjunt extensiu de proves** per a cada capítol del joc **CodeQuestDLC**. Serveix per validar el funcionament correcte del RPG de consola abans de desplegar-lo o afegir noves funcionalitats.

---

## 📜 Capítol 1 – Entrenament del mag

### Casos de prova

1. **Nom vàlid curt**
    - Entrada: `"X341"`
    - Esperat: Mostrar entrenament i títol final correcte segons exp acumulada.
2. **Nom amb caràcters especials**
    - Entrada: `"Álvaro!"`
    - Esperat: Mostrar entrenament sense errors i títol correcte.
3. **Experiència mínima (tot aleatori)**
    - Simular 5 dies amb exp mínima (`1`) i hores mínimes (`1`)
    - Esperat: Títol `Raoden el Elantrí`.
4. **Experiència màxima**
    - Simular 5 dies amb exp màxima (`10`) i hores màximes (`24`)
    - Esperat: Títol `ITB-Wizard el Gris`.
5. **Experiència mitjana**
    - Comprovar que tots els rangs de títol es poden assolir.

### Validacions
- Missatges diaris d’entrenament correctes.
- Acumulació correcta de `exp`.
- Assignació de títol segons rang.

---

## 🐉 Capítol 2 – Combat (Increase LVL)

### Casos de prova

1. **Combat amb monstre amb HP baix**
    - Seleccionar Skeleton (HP 3)
    - Tirades de dau aleatòries
    - Esperat: Derrotat sense errors, nivell augmentat en 1.
2. **Combat amb monstre amb HP alt**
    - Seleccionar Ancient Dragon (HP 50)
    - Tirades de dau diverses
    - Esperat: Derrotat amb múltiples iteracions.
3. **Nivell màxim**
    - Assegurar que si `level = 5` no augmenta més.
4. **Dau ASCII correctament mostrat**
    - Verificar que cada tirada imprimeix la forma correcta del dau.

### Validacions
- HP del monstre resta correctament.
- Missatges de combat coherents.
- Increment de nivell correcte.

---

## ⛏️ Capítol 3 – Loot the Mine

### Casos de prova

1. **Excavació amb èxit**
    - Casella amb moneda (`1`)
    - Esperat: Bits sumats, símbol `🪙` al mapa frontal.
2. **Excavació sense èxit**
    - Casella sense moneda (`0`)
    - Esperat: Missatge `Found nothing`, símbol `❌` al mapa frontal.
3. **Excavació repetida**
    - Tractar d’excavar una casella ja seleccionada
    - Esperat: Incrementar intents i missatge d’advertència.
4. **Exhaurir tots els intents**
    - 5 excavacions completes
    - Esperat: Missatge final amb total de bits obtinguts.

### Validacions
- Mapes `backMap` i `frontMap` consistents.
- Bits calculats correctament.
- Missatges i símbols correctes.

---

## 🎒 Capítol 4 – Inventari

### Casos de prova

1. **Inventari buit**
    - Esperat: Mostrar cap element sense errors.
2. **Inventari amb 1 ítem**
    - Afegir item i mostrar inventari
    - Esperat: Mostrar correctament.
3. **Inventari amb múltiples ítems**
    - Afegir 5 ítems
    - Esperat: Llista completa sense errors.

### Validacions
- Tot el contingut del inventari es mostra correctament.

---

## 🛒 Capítol 5 – Botiga

### Casos de prova

1. **Compra amb bits suficients**
    - Comprar item de preu inferior o igual a bits
    - Esperat: Item afegit, bits descomptats.
2. **Compra sense bits suficients**
    - Intentar comprar item més car que els bits disponibles
    - Esperat: Missatge d’error, inventari inalterat.
3. **Compra d’últim item disponible**
    - Esperat: Inventari actualitzat correctament.
4. **Entrada invàlida**
    - Entrada no numèrica o fora de rang
    - Esperat: Sol·licitar de nou.

### Validacions
- Bits i inventari actualitzats correctament.
- Missatges coherents.

---

## 🔥 Capítol 6 – Atacs per nivell

### Casos de prova

1. **Nivell 1**
    - Esperat: Mostrar només `Magic Spark`.
2. **Nivell 3**
    - Esperat: Mostrar atacs de nivells 1 a 3.
3. **Nivell màxim 5**
    - Esperat: Mostrar tots els atacs.
4. **Nivell 0**
    - Esperat: No mostrar atacs.

### Validacions
- Atacs correctament iterats segons `attacksLvl`.
- Missatges de capçalera correctes.

---

## 🧾 Capítol 7 – Decode Ancient Scroll

### Casos de prova

1. **Decipher spell**
    - Entrada: opció 1
    - Esperat: Espais eliminats de la primera línia.
2. **Count magical runes**
    - Entrada: opció 2
    - Esperat: Comptar vocals correctament en la segona línia.
3. **Extract secret code**
    - Entrada: opció 3
    - Esperat: Nombres extraïts de la tercera línia.
4. **Seqüència completa**
    - Realitzar opcions 1,2,3 successivament
    - Esperat: Missatge de descodificació complet.
5. **Entrada invàlida**
    - Entrada no numèrica o fora de rang
    - Esperat: Missatge d’error i sol·licitud de nova opció.

### Validacions
- Resultats correctes segons línia i opció.
- Missatges i bucles funcionen sense errors.

---

## 🧪 Resum de validació

- Comprovar tots els fluxos d’entrada de menú
- Verificar càlculs aleatoris de combat i mineria
- Validar actualització de bits, nivell, inventari i títols
- Confirmar funcionalitat de loops i condicions
- Revisar visualització dels gràfics ASCII
