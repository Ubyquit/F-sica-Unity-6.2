## **Tema 6: Cinética I - El Enfoque de la Fuerza (Leyes de Newton)**

Este tema se centra en la idea de que los movimientos cambian **porque las fuerzas los obligan a cambiar**.

### **6.1 Segunda Ley de Movimiento de Newton 🚗**
Esta es, sin duda, la ley más importante de toda la mecánica clásica.

* **Concepto:** La aceleración (el cambio de velocidad) de un objeto es directamente proporcional a la fuerza neta que actúa sobre él, e inversamente proporcional a su masa.
* **En palabras simples:** Si empujas algo, acelerará. Si lo empujas el doble de fuerte, acelerará el doble. Si empujas dos objetos de masa diferente con la misma fuerza, el más ligero (menos masa) acelerará mucho más que el más pesado.
* **Fórmula:**
    $$\sum \vec{F} = m \cdot \vec{a}$$
* **Desglose:**
    * $\sum \vec{F}$ (Fuerza Neta): Es la **suma total** de todos los empujones y tirones que actúan sobre un objeto. Se mide en **Newtons (N)**.
    * $m$ (Masa): Es la medida de la inercia del objeto; su resistencia a ser acelerado. Se mide en **kilogramos (kg)**.
    * $\vec{a}$ (Aceleración): Es el cambio en la velocidad (en rapidez o dirección) que *resulta* de la fuerza. Se mide en **metros por segundo al cuadrado (m/s²)**.
* **Ejemplo Real:** Si un auto y un camión tienen el mismo motor (misma fuerza), el auto (menos masa) tendrá una aceleración mucho mayor y ganará la carrera.

### **6.2 Cantidad de Movimiento Lineal (Momentum) 🚛**
* **Concepto:** Es una medida de la "inercia en movimiento". Mide cuánto "costaría" detener a un objeto.
* **Fórmula:**
    $$\vec{p} = m \cdot \vec{v}$$
* **Desglose:**
    * $\vec{p}$ (Momentum Lineal): Se mide en **kg·m/s**.
    * $m$ (Masa): La masa del objeto.
    * $\vec{v}$ (Velocidad): La velocidad del objeto.
* **Ejemplo Real:** ¿Qué es más difícil de detener, una bala de 0.01 kg a 500 m/s o un camión de 10,000 kg a 1 m/s?
    * Momentum Bala: $0.01 \cdot 500 = 5 \text{ kg·m/s}$
    * Momentum Camión: $10,000 \cdot 1 = 10,000 \text{ kg·m/s}$
    ¡El camión, por mucho! Aunque es lento, su enorme masa le da un momentum gigantesco.

* **Razón de Cambio del Momentum:** Esta es la **verdadera** forma en que Newton escribió su Segunda Ley.
    > "La Fuerza Neta es igual a la rapidez con que cambia el momentum."
* **Fórmula:**
    $$\sum \vec{F} = \frac{\Delta \vec{p}}{\Delta t}$$
* **Desglose:**
    * $\sum \vec{F}$: La fuerza neta aplicada.
    * $\Delta \vec{p}$: El cambio total en el momentum.
    * $\Delta t$: El tiempo durante el cual se aplica la fuerza.
* **Ejemplo Real (¡Muy importante!):** ¿Cómo funciona una **bolsa de aire (airbag)**? En un choque, tu cuerpo tiene un gran momentum. Para detenerte (llevar $\vec{p}$ a cero), se necesita aplicar una fuerza.
    * **Sin airbag:** Golpeas el volante. El tiempo del impacto ($\Delta t$) es pequeñísimo (0.01 s). Para cambiar tu momentum, la fuerza ($\vec{F}$) debe ser **enorme**.
    * **Con airbag:** Golpeas la bolsa. Esta se desinfla, **aumentando el tiempo** del impacto ($\Delta t$) a, digamos, 0.5 s. Como $\Delta t$ es mucho más grande, la fuerza ($\vec{F}$) necesaria para detenerte es **mucho más pequeña**. Te salva la vida.

### **6.3 Ecuaciones de Movimiento**
* **Concepto:** No es una nueva ley, es la *aplicación* de la Segunda Ley. Como la fuerza y la aceleración son vectores, podemos descomponer $F=ma$ en cada eje (x, y, z).
* **Fórmulas:**
    $$\sum F_x = m \cdot a_x$$
    $$\sum F_y = m \cdot a_y$$
    $$\sum F_z = m \cdot a_z$$
* **Ejemplo Real:** Cuando analizas un **proyectil** (un cañón):
    * En el eje X (horizontal): $\sum F_x = 0$ (ignorando el aire), por lo tanto, $a_x = 0$ (la velocidad horizontal es constante).
    * En el eje Y (vertical): $\sum F_y = -W$ (el peso), por lo tanto, $m \cdot a_y = -m \cdot g$, lo que nos da $a_y = -g$ (la aceleración de la gravedad).

### **6.4 Cantidad de Movimiento Angular (Momentum Angular) ⛸️**
* **Concepto:** Es el equivalente rotacional del momentum lineal. Es la "inercia de rotación" de un objeto. Mide cuánto "costaría" detener su giro.
* **Fórmula (simplificada para un objeto):**
    $$\vec{L} = \vec{r} \times \vec{p} \quad \text{(o, en magnitud, } L = m \cdot v \cdot r \text{, si es perpendicular)}$$
* **Desglose:**
    * $\vec{L}$ (Momentum Angular): La cantidad de "giro" que tiene.
    * $\vec{r}$ (Vector de Posición): El radio; la distancia desde el eje de giro al objeto.
    * $\vec{p}$ (Momentum Lineal): El momentum lineal ($m \cdot v$) del objeto.
* **Razón de Cambio:** Así como la *Fuerza* cambia el momentum *lineal*, el **Torque** ($\tau$) cambia el momentum *angular*.
    $$\sum \vec{\tau} = \frac{\Delta \vec{L}}{\Delta t}$$

### **6.5 Fuerza Central y Conservación del Momentum Angular**
* **Concepto de Fuerza Central:** Es una fuerza que **siempre apunta hacia un mismo punto central**. El ejemplo perfecto es la **gravedad**. La gravedad de la Tierra siempre jala a la Luna hacia el centro de la Tierra.
* **Conservación de $\vec{L}$:** Cuando la fuerza es central, ¡no produce torque! (porque la fuerza y el radio están en la misma línea). Y si $\sum \vec{\tau} = 0$, entonces $\frac{\Delta \vec{L}}{\Delta t} = 0$, lo que significa que **$L$ no cambia**.
* **En palabras simples:** En ausencia de un torque externo, el momentum angular se conserva (permanece constante).
* **Ejemplo Real 1 (Patinadora):** Una patinadora sobre hielo gira con los brazos extendidos (gran radio $r$). Para girar más rápido, **mete los brazos** (reduce su radio $r$). Como $L$ (que es $\approx m \cdot v \cdot r$) debe ser constante, y $r$ disminuyó, su velocidad de giro $v$ **debe aumentar** drásticamente. 
* **Ejemplo Real 2 (Planetas):** La órbita de un planeta es una elipse. Cuando el planeta está más lejos del Sol ($r$ es grande), se mueve más lento ($v$ es pequeña). Cuando se acerca al Sol ($r$ es pequeña), ¡se mueve mucho más rápido ($v$ es grande)! Todo para mantener $L$ constante.

### **6.6 Principio de Conservación del Momentum (Lineal)**
* **Concepto:** Si no hay *fuerzas externas netas* actuando sobre un sistema, el momentum total del sistema no puede cambiar.
* **Fórmula:**
    $$\vec{p}_{\text{inicial\_total}} = \vec{p}_{\text{final\_total}}$$
* **Ejemplo Real (Colisiones):** Dos bolas de billar chocan.
    * Bola 1 (masa $m_1$) se mueve con $v_1$ y Bola 2 (masa $m_2$) está quieta.
    * Momentum inicial = $m_1 \cdot v_1 + 0$.
    * Después de chocar, la Bola 1 se mueve a $v_{1f}$ y la Bola 2 a $v_{2f}$.
    * Momentum final = $m_1 \cdot v_{1f} + m_2 \cdot v_{2f}$.
    * Por conservación: $m_1 \cdot v_1 = m_1 \cdot v_{1f} + m_2 \cdot v_{2f}$. Las velocidades finales dependen la una de la otra.

### **6.7 Segunda y Tercera Ley de Newton**
* **Concepto:** Este punto conecta las dos leyes. La Tercera Ley (Acción-Reacción) es la *causa* de la conservación del momentum en un sistema.
* **Ejemplo (Colisión de nuevo):** Cuando la Bola 1 golpea a la Bola 2, la Bola 1 ejerce una fuerza $F_{1\to 2}$ sobre la 2. Por la 3ra Ley, la Bola 2 ejerce una fuerza $F_{2\to 1}$ sobre la 1, donde $F_{1\to 2} = -F_{2\to 1}$.
* Estas fuerzas son *internas* al sistema. Como son iguales y opuestas, su suma es cero. Si no hay *otras* fuerzas (externas), la fuerza neta del sistema es cero, y por lo tanto, el momentum total se conserva (como vimos en 6.6).

### **6.8 Fuerzas de Fricción (o Frotamiento) 👟**
* **Concepto:** Es una fuerza que **siempre se opone al movimiento** (o al intento de movimiento) entre dos superficies en contacto.
* **Hay dos tipos:**
    1.  **Fricción Estática ($f_s$):** Es la fuerza que debes vencer para *empezar* a mover algo. Es una fuerza "inteligente": si empujas un refri con 10 N y no se mueve, es porque $f_s$ te responde con -10 N. Si empujas con 50 N y no se mueve, $f_s$ te responde con -50 N. Tiene un valor máximo.
    2.  **Fricción Cinética ($f_k$):** Es la fuerza que se opone al movimiento una vez que el objeto *ya se está deslizando*. Generalmente es *menor* que la fricción estática máxima.
* **Fórmula (simplificada):**
    $$f \le \mu_s \cdot N \quad \text{(Estática)}$$
    $$f_k = \mu_k \cdot N \quad \text{(Cinética)}$$
* **Desglose:**
    * $f$: Fuerza de fricción.
    * $\mu$ (mu): Coeficiente de fricción. Es un número sin unidades que depende de qué tan "ásperas" son las dos superficies (ej. hule contra asfalto $\mu \approx 0.8$, acero contra hielo $\mu \approx 0.1$).
    * $N$: Fuerza Normal. Es la fuerza con la que las superficies se "aprietan" entre sí (usualmente, el peso del objeto).
* **Ejemplo Real:** Es mucho más difícil "despegar" (vencer $f_s$) una caja pesada del suelo que mantenerla moviéndose (vencer $f_k$).

### **6.9 Ley de Gravitación de Newton**
* **Concepto:** (Como vimos en Tema 1) Todos los objetos con masa se atraen entre sí.
* **Fórmula:**
    $$F_g = G \frac{m_1 \cdot m_2}{r^2}$$
* **Desglose:**
    * $F_g$: Fuerza de gravedad.
    * $G$: Una constante universal (un número muy pequeño).
    * $m_1, m_2$: Las masas de los dos objetos.
    * $r$: La distancia entre sus centros.
* **Relevancia aquí:** Esta es la fuerza que usamos en $F=ma$ para todos los problemas astronómicos (planetas, satélites, etc.).

### **6.10 Trayectoria bajo Fuerza Central**
* **Concepto:** Es la conclusión de todo lo anterior. Cuando resuelves $F=ma$ (específicamente $F_g = m \cdot a$) para un objeto bajo una fuerza central (como la gravedad), la trayectoria resultante (el camino que sigue) no es cualquier cosa.
* **Resultado:** El camino es siempre una **sección cónica**: un círculo, una elipse (planetas), una parábola (cometas de una sola visita) o una hipérbola (cometas que son despedidos del sistema solar).

---

## **Tema 7: Cinética II - El Enfoque de la Energía (La Contabilidad)**

Este enfoque es diferente y, a menudo, ¡mucho más fácil! En lugar de lidiar con vectores de fuerza, simplemente "contamos" la energía al inicio y al final. Es como hacer contabilidad.

### **7.1 Trabajo Realizado por una Fuerza (W) 📦**
* **Concepto:** En física, "trabajo" no es esfuerzo. Es la **transferencia de energía** a un objeto al aplicarle una fuerza a lo largo de una distancia.
* **En palabras simples:** Si empujas algo y **se mueve**, hiciste trabajo. Si empujas una pared y no se mueve, no hiciste trabajo (aunque te canses).
* **Fórmula:**
    $$W = F \cdot d \cdot \cos(\theta)$$
* **Desglose:**
    * $W$ (Trabajo): Se mide en **Joules (J)**.
    * $F$: La magnitud de la fuerza que aplicas.
    * $d$: La distancia que se movió el objeto.
    * $\theta$ (theta): El ángulo entre la fuerza y la dirección del movimiento.
* **Ejemplo Real:** Arrastras una maleta.
    * Jalas del asa con una fuerza $F$ en un ángulo $\theta$ de 30°. La maleta se mueve una distancia $d$ horizontalmente.
    * Tu trabajo es $F \cdot d \cdot \cos(30^\circ)$. Solo la parte de tu fuerza que jala *horizontalmente* hace trabajo. La parte que jala hacia arriba no.

### **7.2 Energía Potencial (PE o U) 🎢**
* **Concepto:** Es **energía almacenada** en virtud de la posición o configuración de un objeto. Es el "potencial" de hacer trabajo.
* **Dos tipos principales:**
    1.  **Potencial Gravitatoria:** Energía almacenada por estar en una altura.
        $$PE_g = m \cdot g \cdot h$$
        * $m$: masa, $g$: gravedad (9.8 m/s²), $h$: altura.
        * **Ejemplo:** Una roca en lo alto de una colina tiene mucha $PE$.
    2.  **Potencial Elástica:** Energía almacenada en un resorte comprimido o estirado.
        $$PE_e = \frac{1}{2} k \cdot x^2$$
        * $k$: Constante del resorte (qué tan "duro" es).
        * $x$: Distancia que se estiró/comprimió desde su posición normal.
        * **Ejemplo:** Un arco tensado con una flecha. 

### **7.3 Energía Cinética (KE o K) 💨**
* **Concepto:** Es la **energía del movimiento**. Cualquier cosa que se mueva tiene $KE$.
* **Fórmula:**
    $$KE = \frac{1}{2} m \cdot v^2$$
* **Desglose:**
    * $KE$: Energía cinética, medida en **Joules (J)**.
    * $m$: Masa.
    * $v$: Rapidez (velocidad).
* **Importante:** La velocidad está al cuadrado. Esto significa que si duplicas tu velocidad (de 30 a 60 km/h), tu energía cinética se vuelve **cuatro veces** mayor. Por eso los choques a alta velocidad son tan devastadores.

### **7.4 Transformación de Energía (PE $\to$ KE)**
* **Concepto:** Este es el corazón de la conservación de la energía. La energía no se crea ni se destruye, solo se transforma.
* **Ejemplo Real (La Montaña Rusa):**
    1.  **En lo más alto:** El carrito está casi quieto ($v \approx 0$). Está a una altura $h$ máxima.
        * $KE \approx 0$
        * $PE$ es Máxima.
    2.  **Bajando:** El carrito pierde altura $h$ (pierde $PE$), pero gana velocidad $v$ (gana $KE$). La $PE$ se está transformando en $KE$.
    3.  **En lo más bajo:** La altura $h=0$. La velocidad $v$ es máxima.
        * $PE = 0$
        * $KE$ es Máxima.

### **7.5 El Teorema del Trabajo y la Energía**
* **Concepto:** Este es el "puente" que conecta el Tema 6 (Fuerzas) con el Tema 7 (Energía).
* **Enunciado:** El **trabajo neto** ($W_{\text{neto}}$) realizado sobre un objeto es igual al **cambio en su energía cinética** ($\Delta KE$).
* **Fórmula:**
    $$W_{\text{neto}} = KE_{\text{final}} - KE_{\text{inicial}} \quad (o \quad W_{\text{neto}} = \Delta KE)$$
* **Ejemplo Real:** Para frenar un auto (llevar su $KE$ a 0), los frenos deben hacer un "trabajo negativo" (una fuerza de fricción $F$ a lo largo de una distancia $d$). La fórmula $W = \Delta KE$ te dice exactamente qué distancia de frenado $d$ necesitas.

### **7.8 y 7.9 Ley de la Conservación de la Energía (+ Ejemplos)**
* **Concepto:** Si en un sistema solo actúan **fuerzas conservativas** (como la gravedad o los resortes, pero NO la fricción), la energía mecánica total ($KE + PE$) nunca cambia.
* **Fórmula (La Ecuación de Oro):**
    $$E_{\text{total\_inicial}} = E_{\text{total\_final}}$$
    $$KE_i + PE_i = KE_f + PE_f$$
* **Ejemplo (Péndulo):**
    * **En el extremo (A):** Sueltas el péndulo. $v=0 \to KE=0$. Altura máxima $\to PE=\text{max}$.
    * **En el fondo (B):** $v=\text{max} \to KE=\text{max}$. Altura cero $\to PE=0$.
    * Usando la fórmula: $(0 + PE_{\text{max}})_A = (KE_{\text{max}} + 0)_B$.
    * $mgh_{\text{max}} = \frac{1}{2}mv_{\text{max}}^2$. Puedes despejar la velocidad máxima sin saber nada de fuerzas ni aceleraciones, ¡solo sabiendo la altura!

### **7.10 Potencia y Eficiencia ⚡**
* **Concepto (Potencia):** No es lo mismo que el trabajo o la energía. La potencia es la **rapidez** con la que se hace trabajo o se usa la energía.
* **Fórmula:**
    $$P = \frac{W}{t} \quad \text{(Potencia = Trabajo / tiempo)}$$
    (También: $P = F \cdot v$, Potencia = Fuerza x velocidad)
* **Desglose:**
    * $P$: Potencia, se mide en **Watts (W)**. (1 Watt = 1 Joule por segundo).
* **Ejemplo:** Un foco de 100 W consume 100 Joules de energía eléctrica cada segundo. Un motor potente puede levantar un elevador (hacer trabajo $mgh$) muy rápido.
* **Concepto (Eficiencia):** Es la comparación entre el trabajo útil que obtienes y la energía que pagaste.
* **Fórmula:**
    $$\text{Eficiencia} = \frac{\text{Energía Útil}}{\text{Energía Total Consumida}} \cdot 100\%$$
* **Ejemplo:** Un foco incandescente (viejo) es muy ineficiente. Consume 100 J de electricidad (Total) pero solo produce 5 J de luz (Útil). El resto (95 J) se pierde como calor. Su eficiencia es del 5%. Un LED es >90% eficiente.

### **7.12 Principio de Impulso y Cantidad de Movimiento**
* **Concepto:** Este es el "hermano gemelo" del Teorema del Trabajo-Energía. Relaciona la *fuerza y el tiempo* con el *momentum*.
* **Impulso ($J$):** Es una fuerza aplicada durante un corto período de tiempo.
* **Principio:** El Impulso aplicado a un objeto es igual al **cambio en su momentum**.
* **Fórmula:**
    $$\vec{J} = \Delta \vec{p} \quad \to \quad \vec{F} \cdot \Delta t = \vec{p}_{\text{final}} - \vec{p}_{\text{inicial}}$$
* **Ejemplo Real:** Batear una pelota de béisbol.
    * La pelota viene con un momentum $\vec{p}_{\text{inicial}}$.
    * El bate aplica una fuerza $\vec{F}$ enorme durante un tiempo $\Delta t$ muy corto (el Impulso).
    * La pelota sale disparada con un nuevo momentum $\vec{p}_{\text{final}}$.
    * Esta fórmula es perfecta para calcular la fuerza del bate, algo que sería casi imposible de hacer con $F=ma$.

### **7.13 Fuerzas No Conservativas (La Fricción)**
* **Concepto:** ¿Qué pasa cuando SÍ hay fricción? La energía mecánica *no se conserva*. Se "pierde" (en realidad, se transforma en calor).
* **Fuerzas No Conservativas ($F_{nc}$):** Son fuerzas como la fricción o la resistencia del aire, donde el trabajo que hacen SÍ depende del camino (arrastrar una caja en círculos gasta más energía que en línea recta).
* **Fórmula (La Ecuación de Oro Completa):**
    $$KE_i + PE_i + W_{nc} = KE_f + PE_f$$
    (La energía inicial, más/menos el trabajo hecho por la fricción, es igual a la energía final)
* **Ejemplo:** Un esquiador baja una colina. Empieza con $PE=10,000$ J. Abajo, su $KE$ es de solo $8,000$ J. ¿Qué pasó con los 2,000 J que faltan? Ese fue el trabajo negativo hecho por la fricción y la resistencia del aire ($W_{nc} = -2000$ J), que se disipó como calor.