INFORMAÇÕES DO PROJETO
Unity Version: 2022.3 LTS
Pipeline: Universal Render Pipeline (URP)
Plataforma da Build: Windows x86_64 (ou WebGL)
Cena Principal: Zeus_Showcase.unity

TEMA ESCOLHIDO: TEMPLO DE ZEUS
Escolhi o tema Zeus por sentir ser mais direto na criação uma atmosfera épica e divina com uma certa sombriedade.
Eu tentei explorar mais efeitos de energia elétrica com emissive forte, cores vivas busquei criar um visual mágico, vibrante e de alto impacto visual.

SHADERS CRIADOS:
1.sg_Clouds
	Nesse shader eu uso noise para criar as nuvens e faço com que o o proprio noise deforme a malha, essa que, 
	por sinal, tem que ser bem detalhada pra conseguir manter uma deformação suave.
2.sg_Glow
	Shader simples só pra conseguir ter um material com emissivo que use o preto da textura como alpha.
3.sg_Lightining
	Esse shader é mais complexo, ele não usa textura, eu uso um noise pra deformar a UV de um node retangle, depois eu pego apenas a borda 
	da figura deformada para usar no emissivo, assim eu tenho um efeito de glow mais intenso com o meio de um cor a borda de outra.
4.sg_Sprite
	Eu fiz esse shader pra poder usar usar o efeito de emissivo no flipbook, com um glow bem bonito a fumaça ia ter um tom mais divino também.
5.sg_Statuet
	A Estatua precisava de um shader só pra ela para que eu pudesse aplicar os efeitos de dissolve e foil que eu queria.
6.sg_Wave
	Esse efieto ele usar a propriedade de profundidade da câmera ser feito por isso eu criei ele, pra ter um efeito bem interativo de forma fácil.

EFEITOS VISUAIS:
1. VFX_Lightining
	Criado com VFX Graph usar o shader Lightning pra spawnar os raios
2. ps_Smoke
	Partículas feitas com o ParticleSystem, são as partículas de fumaça que ajudam na dramaticidade da cena.
3. Sparks e star
	São particulas que ajudam a dar mais impacto ao efeito de raio.

ILUMINAÇÃO E POS PROCESSAMENTO
-Bloom intenso (estilo divino)
-Color Grading com sombras frias e highlights dourados
-Vignette suave
-Chromatic Aberration leve
-Directional Light azul suave

INTERATIVIDADE:
	A Timeline é disparada automaticamente quando o jogador interage atraves do click com dois objetos na scena.
	Primeiro a porta e depois e estátua que substitui o altar, nesse caso.

	O sistema usa: Manager_Interaction.cs ele utiliza o Rayvast para disparar um Ray da câmera na posição o cursor que ao interagir com
	algum colider que contenha o script Activate_Timeline.cs chama a função ActivateTL que ativa a timeline que controla a sequência de efeitos e
	animações.

TECNICAS DE OTIMIZAÇÃO:
	Materiais instanciados
	Shaders simples com poucos processamentos
	Limitação de partículas (overdaw)

ASSETS DE TERCEIROS UTILIZADOS:
	Skybox estilizado gratuíto - baixado da unity store
	Sond effects gratuítos - baixados pelo site mixkit


COMO JOGAR:
	Use as setas para mover e o mouse para olhar ao redor e interagir
	***RECOMENDO SE MANTER NO LUGAR PARA UMA MELHOR VISUALIZAÇÃO DOS EVENTOS***