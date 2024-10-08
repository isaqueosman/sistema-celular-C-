# Desafio Abstraindo um Celular
Para este desafio, fiz o código do zero mesmo havendo uma versão disponível no repositório oficial da DIO. Também utilizei conhecimentos em UML para criar meu próprio diagrama personalizado e conhecimentos do módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](https://github.com/isaqueosman/sistema-celular-C-/blob/main/diagrama.png)
)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Comentário
O código está pronto, você poderá modificar obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional.
