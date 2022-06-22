using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "O que é TMB ou Taxa Metabólica Basal?")
            {
                textBox1.Text = "Em resumo, TMB significa Taxa Metabólica Basal. Na seção anterior, fizemos uso desse conceito, só que com a sigla (TMB)." +"\n"+
                    "A TMB diz respeito ao gasto energético em repouso de nosso corpo. Ou seja, a quantidade de energia necessária para manter as funções básicas do corpo, como batimentos cardiácos, trocas gasosas no pulmão e tudo mais, sem levar em conta as atividades físicas.\n" +"\n"+
                    "Esse valor é muito importante para o desenvolvimento da sua dieta, pois permite calcular a quantidade de calorias mínima para você emagrecer ou até mesmo ganhar mais massa muscular se esse for seu desejo. No caso, a Taxa Metabólica Basal ou TMB precisa ser multiplicada pelo nível de atividade física, tornando-se assim o TDEE.";
            }
            if(comboBox1.Text == "O que é o TDEE ou GET?")
            {
                textBox1.Text = "O TDEE nada mais é que o valor total de energia que você queima por dia. A sigla está em Inglês (Total Daily Energy Expenditure, ou Gasto Total Diário – GET) , por isso não confere com as iniciais em Português.";
            }
            if(comboBox1.Text == "IMC: o que é?")
            {
                textBox1.Text = "O IMC é um cálculo simples que permite avaliar se a pessoa está dentro do peso que é considerado ideal para a sua altura. Também conhecido como Índice de Massa Corporal, o IMC é uma fórmula utilizada por vários profissionais de saúde, incluindo médicos, enfermeiros e nutricionistas, para saber, de uma forma rápida, se a pessoa precisa ganhar ou perder peso.\n" +
                    "Embora seja uma ferramenta muito comum, o IMC não é considerada a forma mais exata de avaliar o peso, já que não leva em consideração a composição corporal. Por isso, é comum que no caso de atletas (que possuem uma maior quantidade de massa muscular) seja aconselhado o uso de outras técnicas, como a bioimpedância, para uma avaliação mais detalhada do peso. Entenda o que é a bioimpedância.";
            }
            if(comboBox1.Text == "O que são macronutrientes?")
            {
                textBox1.Text = "Proteínas, carboidratos e gorduras são os macronutrientes, grandes categorias de nutrientes que devem constituir a maior parte da dieta. Eles fornecem energia ao corpo e são necessários em grandes quantidades e de forma equilibrada para manter as funções diárias do corpo, de acordo com a Organização Mundial de Saúde (OMS).";
            }
            if(comboBox1.Text == "Proteínas")
            {
                textBox1.Text = "A proteína é um componente importante de todas as células do corpo. Cabelos e unhas, por exemplo, são feitos principalmente delas. O seu corpo também as utiliza para construir e reparar tecidos, produzir enzimas, hormônios e outras substâncias químicas. Ela ainda é um componente de ossos, músculos, cartilagens, pele e sangue." +
                    "As principais fontes de proteínas são carne de boi, frango, peixe, leite, ovos, queijos e leguminosas como feijão, ervilha, lentilha, tofu, quinoa, nozes, espinafre, brócolis e aspargo.";
            }
            if(comboBox1.Text == "Carboidratos")
            {
                textBox1.Text = "Os carboidratos são a principal fonte de energia proveniente da sua dieta. Quando ingeridos, eles são quebrados em pedaços menores e se tornam açúcares simples, como a glicose. Os diferentes tipos de carboidratos incluem amidos, açúcares e fibras. Para um suprimento constante de energia, consuma alimentos ricos em amido, como pão, batata, macarrão, arroz e cereais de forma balanceada.";

            }
            if(comboBox1.Text == "Gorduras")
            {
                textBox1.Text = "Embora seja verdade que algumas gorduras trazem riscos à saúde, elas também são importantes fontes de energia e ajudam o organismo a absorver certos nutrientes. Além disso, fornecem ácidos graxos essenciais que o corpo não pode produzir." +
                    "As gorduras insaturadas são as gorduras consideradas “boas”. Existem dois tipos: monoinsaturadas e poliinsaturadas. As monoinsaturadas são encontradas no azeite de oliva, abacate e nozes. Já as poliinsaturadas são encontradas nos óleos de girassol, soja, canola, milho, nas sementes de abóbora e em peixes como o atum, sardinha e em frutos do mar. O ômega 3 é um tipo particularmente benéfico de gordura poliinsaturada.";
            }
            if(comboBox1.Text == "O que são micronutrientes?")
            {
                textBox1.Text = "Vitaminas e minerais são os micronutrientes, dos quais o corpo precisa em menores quantidades. No entanto, isso não significa que eles sejam dispensáveis. Pelo contrário: são fundamentais para funções básicas do nosso organismo, como a metabolização dos alimentos e a produção de energia." +
                    "A deficiência de micronutrientes pode provocar uma série de problemas no corpo. A falta de ferro, por exemplo, pode causar a anemia, que ocorre quando não há glóbulos vermelhos suficientes para suprir a necessidade de oxigênio do corpo, ou quando essas células não carregam uma proteína importante chamada hemoglobina." +
                    "Já a vitamina D, quando não adquirida pelo corpo em quantidades adequadas, pode minar a força dos ossos e músculos. Já a deficiência das vitaminas do complexo B, especialmente B2, B6, assim como de ácido fólico, impede o início do processo de produção de energia. Já a B1 converte carboidrato em energia e também deve ser consumida em quantidades adequadas.";
            }
            if(comboBox1.Text == "Como consumir macro e micronutrientes?")
            {
                textBox1.Text = "A melhor maneira de garantir que você está recebendo a quantidade certa de macros e micronutrientes é verificar seus hábitos alimentares. A composição de uma dieta diversificada e equilibrada deve incluir todos os grupos de alimentos que fornecem macronutrientes (frutas, legumes, grãos e fontes de proteínas, como carnes brancas e ovos), assim como as fontes de micronutrientes, especialmente frutas e vegetais." +
                    "Planejar as refeições é forma de garantir que você está comendo direitinho, desde o café da manhã até o jantar, sem esquecer dos lanches nutritivos! Toda refeição é uma oportunidade para diversificar a dieta e comer com saúde.";
            }
            if(comboBox1.Text == "O que é uma caloria?")
            {
                textBox1.Text = "Para entender o que é o déficit calórico é importante, antes de tudo, esclarecer o conceito de calorias." +
                    "A caloria nada mais é do que a medida da energia que os alimentos possuem, ou seja, os alimentos fornecem energia que será utilizada pelo corpo para funcionar corretamente." +
                    "Nossas células do corpo são responsáveis por utilizar os carboidratos, proteínas e gorduras ingeridos para gerar essa energia no cotidiano." +
                    "No entanto, a energia nem sempre é completamente consumida, o que faz com que ela seja armazenada no corpo como gordura.";

            }
            if(comboBox1.Text == "Conceito de balanço energético  ")
            {
                textBox1.Text = "O balanço energético está bastante relacionado às calorias e diz respeito à relação entre as calorias que o corpo gasta e a quantidade de calorias que ele consome. Sendo assim, ele pode ser neutro, positivo ou negativo: " +
                    "Balanço energético neutro: nesse caso, o corpo consome a mesma quantidade de calorias que gasta, o que faz com que o nosso peso se mantenha o mesmo;" +
                    "Balanço energético positivo: esse cenário indica que nosso corpo ingere mais calorias do que gasta, ou seja, os nutrientes serão estocados no nosso corpo como forma de gordura e, assim, iremos aumentar nosso peso;" +
                    "Balanço energético negativo: o último tipo de balanço energético é aquele em que nós ingerimos menos calorias do que gastamos, ou seja, nosso corpo precisa usar o estoque interno para funcionar, o que provoca o emagrecimento.";
            }
            if(comboBox1.Text == "O que é déficit calórico?")
            {
                textBox1.Text = "Agora que você entendeu o que é caloria e o que é balanço energético, fica ainda mais fácil compreender o que é déficit calórico." +
                    "Ele diz respeito ao cenário em que o nosso balanço energético é negativo, isto é, quando nosso corpo tem uma quantidade negativa de calorias, ou seja, nosso gasta mais energia do que consome." +
                    "Como vimos, isso significa que para o corpo funcionar corretamente, o organismo vai usar os próprios estoques energéticos já armazenados, forçando a queima de gordura estocada." +
                    "Por consumir a gordura armazenada, o déficit calórico costuma ser uma alternativa para quem busca emagrecer.";



            }
            if(comboBox1.Text == "Afinal, o que é o exercício cardiovascular?")
            {
                textBox1.Text = "Em termos práticos, pode-se dizer que qualquer exercício físico pode ser considerado um exercício “cardio”. Afinal, todas as formas de exercício demandam energia do sistema cardiovascular.  No entanto, tecnicamente, a indústria de fitness geralmente descreve como exercício cardiovascular aquele que aumenta a demanda de oxigênio para os músculos durante um longo período de tempo. O Colégio Americano de Medicina do Esporte (ACSM) descreve o exercício cardio como “exercício que usa grandes grupos musculares e é feito por 30 – 60 minutos.”" +
                    "No entanto, para começar a obter os benefícios dos exercícios físicos, basta se movimentar. O corpo humano é uma máquina incrível, capaz de se adaptar a diferentes estresses. Os esforços e resultados vão depender do seu objetivo. O importante é manter o corpo em movimento e, preferivelmente, com o acompanhamento de um educador físico para lhe dar as orientações adequadas." +
                    "Hoje em dia, o treinamento funcional atinge um maior público comparado a outras modalidades. Pois além de estimular a parte aeróbica do indivíduo, ele também atende as necessidades e as funções dos músculos. Ou seja, um trabalho completo para quem procura maior qualidade de vida!";
            }
            if(comboBox1.Text == "O que é musculação?")
            {
                textBox1.Text = "A musculação é uma modalidade de treinamento físico realizado contra resistência de pesos externos, chamada também de treino resistido, que tem como objetivo o aumento hipertrofia muscular, ganho de força e potência. É uma atividade de duração instantânea e elevada intensidade." +
                    "Não é uma modalidade esportiva, mas contribui para a preparação de múltiplos atletas de diversas modalidades, além de ser o alicerce do treinamento de culturismo e também de algumas modalidades olímpicas como o levantamento de peso." +
                    "A musculação é a principal atividade nas academias para preparação física, contribui além do crescimento muscular com a diminuição da gordura corpórea e o incremento da massa óssea. Sua prática constante leva a transformação harmoniosa da constituição física humana.";


            }
            if(comboBox1.Text == "Como funcionam os músculos do corpo humano?")
            {
                textBox1.Text = "O conjunto de músculos do corpo humano constitui o sistema muscular. São cerca de 600 músculos que juntos representam de 40 a 50% do peso corporal. Sua função é de contrair, relaxar e gerar movimentos que nos possibilita andar, sentar, pular, correr, escrever, além de favorecer a circulação sanguínea no organismo, urinar, impelir o alimento ao longo do tubo digestivo, sorrir, respirar, piscar, enfim são incontáveis movimentos." +
                    "Toda nossa locomoção depende da ação conjunta dos ossos, articulações e músculos perante a regulação do sistema nervoso. Os músculos são classificados em voluntários, aqueles que se contraem de acordo com a vontade humana e os involuntários que são controlados pelo sistema nervoso vegetativo e não por controle voluntário. Esses são: o aparelho respiratório, as paredes das vísceras e o aparelho circulatório, são chamados músculos lisos (com exceção dos músculos cardíacos que são estriados)." +
                    "Fazem parte dos músculos voluntários os chamados músculos esqueléticos, formados por estrias e mais conhecidos como músculos estriados. Os músculos esqueléticos são formados por fibras organizadas no mesmo agrupamento muscular e podem chegar a mais de 1 milhão de fibras musculares em cada agrupamento." +
                    "Essas fibras não são visíveis a olho nu. Cada uma delas é fixada ao osso através dos tendões com um nervo motor, formando uma unidade motora. Quando a unidade motora é estimulada por um impulso nervoso do cérebro ou da medula espinhal, ocorre a contração muscular.";
            }
            if(comboBox1.Text == "Benefícios da musculação para o corpo humano")
            {
                textBox1.Text = "São profusos os benefícios da musculação para o corpo e cada vez mais as pessoas estão antenadas às vantagens que essa atividade pode proporcionar como:" +
                    "A realização rotineira de musculação tonifica os músculos, proprocionamento maior força, resistência muscular localizada e potência;" +
                    "Musculação contribui para o aceleramento do metabolismo e consequentemente maior gasto calórico;" +
                    "Gera incrementos da massa óssea, auxiliando na prevenção de algumas doenças como a osteoporose;" +
                    "Aumenta a força;" +
                    "Contribui para a saúde coronariana, pois a musculação treina o coração para esforços intensos, com isso a frequência cardíaca e a pressão arterial sobem parcialmente quando a pessoa é exposta algum estímulo;" +
                    "Melhora a parte estética, dessarte à autoestima;" +
                    "Fortalece a região da coluna vertebral, a flexibilidade e diminui dores locais;" +
                    "Assim como muitos exercícios físicos, a musculação melhora o sistema imunológico;" +
                    "Contribui positivamente para a coordenação motora e o equilíbrio;" +
                    "Melhora a concentração e o aprendizado;";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
