using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour {

	
	public Text text;

	private enum States {start, casa_hall, casa_caminho_esq, casa_caminho_dir, entrada_residencia, trancado, segundo_andar, 
	sala_de_estar, cadeira_de_rodas, cadeira_de_rodas2, porao, escada2, morte, parede_x, parede_cai, parede_nao_cai,
	pegou_livro, livro_aberto, livro_fechado, porao3, cozinha, quintal, start2, mesa, balcao, cozinheiro, cozinha2, 
	cemiterio, praia, parquinho, ponto, rua, ponto_ir, ponto_ficar, jardim, caminho_esq2, pedras, migalhas, floresta,
    lago, quarto_telefone, lata, lata2, lata3, lata4, lata5, banheiro, espelho, corredor, quarto_velha, janela, cama,
    cama2, cama3, cama4, cama5, cama6, cama7, cama8, cama9, cama_morte, livro_queimado, livro_seu, fim};


	public Sprite[] myArrayImage; 
	public Image Imagem;

	public GameObject ichave;
	public GameObject iisqueiro;
	public GameObject ilanterna;
	public GameObject ilivro;
	public GameObject imachado;

	private enum ImageStates {banheiro, corredor1, corredor2, cozinha, escada_sem_lanterna, hall, livro_altar, porao, porao_escada, quarto, 
	quarto_telefone, sala, segundo_andar_escada, floresta1, floresta2, lago, migalhas, pedras, jd, lateralDir, lateralEsq, portao, start, cemiterio, 
	cut_praia, parquinho, quintal, ponto_bus, street, escada_lanterna, died, won};

    
	private States myState;


	private bool janelaLobo = false;
	private bool isqueiro = false;
	private bool lanterna = false;
	private bool machado = false;
	private bool livro = false;
	private bool chave = false;
	private bool livroSeu = false;

	private int contador;

	void Start () {

	Imagem.sprite = myArrayImage[(int)ImageStates.start];


	myState = States.start;

	contador = 0;

	}	

	void Update ()
	{

		if (myState == States.start) {
			State_start ();

		} else if (myState == States.casa_hall) {

			Casa_hall ();

		} else if (myState == States.casa_caminho_dir) {

			Casa_Caminho_Dir ();

		} else if (myState == States.casa_caminho_esq) {

			Casa_Caminho_Esq ();

		} else if (myState == States.trancado) {
		  
			Trancado ();	
		} else if (myState == States.entrada_residencia) {

			Entrada_Residencia ();
		} else if (myState == States.segundo_andar) {

			Segundo_Andar ();

		} else if (myState == States.sala_de_estar && janelaLobo == false) {

			Sala_de_Estar ();

		} else if (myState == States.sala_de_estar && janelaLobo == true) {

			Sala_de_Estar2 ();

		} else if (myState == States.cadeira_de_rodas && isqueiro == false) {

			Cadeira_de_Rodas ();

		} else if (myState == States.cadeira_de_rodas && isqueiro == true) {

			Cadeira_de_Rodas2 ();

		} else if (myState == States.cadeira_de_rodas && isqueiro == false && janelaLobo == true) {

			Cadeira_de_Rodas3 ();
		
		} else if (myState == States.cadeira_de_rodas && isqueiro == true && janelaLobo == true) {

			Cadeira_de_Rodas4 ();
		
		} else if (myState == States.escada2) {

			Escada2 ();

		} else if (myState == States.porao && lanterna == false) {

			Porao ();

		} else if (myState == States.porao && lanterna == true) {

			Porao2 ();

		} else if (myState == States.parede_x) {

			Parede_X ();

		} else if (myState == States.parede_cai) {

			Parede_Cai ();
		
		} else if (myState == States.parede_nao_cai) {

			Parede_Nao_Cai ();

		} else if (myState == States.pegou_livro) {

			Pegou_Livro ();

		} else if (myState == States.porao3) {

			Porao3 ();

		} else if (myState == States.livro_aberto) {

			Livro_Aberto ();

		} else if (myState == States.livro_fechado) {

			Livro_Fechado ();

		} else if (myState == States.escada2) {

			Escada2 ();

		} else if (myState == States.morte) {

			Morte ();
	
		} else if (myState == States.cozinha) {

			Cozinha ();

		} else if (myState == States.quintal) {

			Quintal ();

		} else if (myState == States.start2) {

			Start2 ();

		} else if (myState == States.mesa && lanterna == false) {

			Mesa ();

		} else if (myState == States.mesa && lanterna == true) {

			Mesa2 ();

		} else if (myState == States.balcao) {

			Balcao ();

		} else if (myState == States.cozinheiro) {
			
			Cozinheiro ();

		} else if (myState == States.cozinha2) {
			
			Cozinha2 ();

		} else if (myState == States.cemiterio) {
			
			Cemiterio ();

		} else if (myState == States.praia && livroSeu ==false ) {
			
			Praia ();

		}  else if (myState == States.praia && livroSeu ==true ) {
			
			Praia2 ();

		} else if (myState == States.parquinho && machado == false) {
			
			Parquinho ();

		} else if (myState == States.parquinho && machado == true) {
			
			Parquinho2 ();

		} else if (myState == States.ponto) {
			
			Ponto ();

		} else if (myState == States.rua) {
			
			Rua ();

		} else if (myState == States.ponto_ficar) {
			
			Ponto_Ficar ();

		} else if (myState == States.ponto_ir) {
			
			Ponto_Ir ();

		} else if (myState == States.jardim) {
			
			Jardim ();

		} else if (myState == States.caminho_esq2) {
			
			Casa_Caminho_Esq2 ();

		} else if (myState == States.pedras) {
			
			Pedras ();

		} else if (myState == States.migalhas) {
			
			Migalhas ();

		} else if (myState == States.floresta) {
			
			Floresta ();

		} else if (myState == States.lago) {
			
			Lago ();

		} else if (myState == States.quarto_telefone) {
			
			Quarto_Telefone ();

		} else if (myState == States.lata) {
			
			Lata ();

		} else if (myState == States.lata2) {
			
			Lata2 ();

		} else if (myState == States.lata3) {
			
			Lata3 ();

		} else if (myState == States.lata4) {
			
			Lata4 ();

		} else if (myState == States.lata5) {
			
			Lata5 ();

		} else if (myState == States.banheiro) {
			
			Banheiro ();

		} else if (myState == States.espelho) {
			
			Espelho ();

		} else if (myState == States.corredor) {
			
			Corredor ();

		} else if (myState == States.quarto_velha) {
			
			Quarto_Velha ();

		} else if (myState == States.janela && janelaLobo == false) {
			
			Janela ();

		} else if (myState == States.janela && janelaLobo == true) {
			
			Janela2 ();

		} else if (myState == States.cama && chave == false) {
			
			Cama ();

		} else if (myState == States.cama2) {
			
			Cama2 ();

		} else if (myState == States.cama3) {
			
			Cama3 ();

		} else if (myState == States.cama4) {
			
			Cama4 ();

		} else if (myState == States.cama5) {
			
			Cama5 ();

		} else if (myState == States.cama6) {
			
			Cama6 ();

		} else if (myState == States.cama7) {
			
			Cama7 ();

		} else if (myState == States.cama8) {
			
			Cama8 ();

		} else if (myState == States.cama9) {
			
			Cama9 ();

		} else if (myState == States.cama_morte) {
			
			Cama_Morte ();

		} else if (myState == States.cama && chave == true) {
			
			Cama_Chave ();

		}  else if (myState == States.livro_queimado && isqueiro == true) {
			
			Livro_Queimado ();

		}   else if (myState == States.livro_queimado && isqueiro == false) {
			
			Livro_Queimado2 ();

		}  else if (myState == States.fim) {
			
			Fim ();

		}   else if (myState == States.livro_seu) {
			
			Livro_Seu ();

		} 

		if (contador == 3) {

			Cama_Morte ();
		}

	}

		void State_start ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.start];

		text.text = "Existe uma lenda que diz que uma bruxa vive na casa mais velha e afastada do bairro. " +
		"Dizem que coisas esquisitas acontecem em volta daquele local, barulhos assustadores, sombras estranhas e muitos outros mistérios. " +
		"Você foi desafiado por seus amigos a ir lá em uma noite de lua cheia e roubar uma página do livro de mágia da bruxa. " +
		"Enquanto eles aguardavam no portão de entrada fora das propriedades da casa, você foi em direção aquela casa velha e assustadora. \n\n" +
			"Aperte <b>C</b>  para para tentar entrar pela porta da frente da casa. \n" +
			"Aperte <b>E</b> para ir para o caminho da esquerda da casa. \n" +
			"Aperte <b>D</b> para ir para o caminho da direita da casa. \n" +
			"Aperte <b>V</b> para voltar para onde seus amigos estavam e desisitir de tudo isso. \n";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.casa_hall;

		} else if (Input.GetKeyDown (KeyCode.E)) {
		    myState = States.casa_caminho_esq;

		}  else if (Input.GetKeyDown (KeyCode.D)) {
		    myState = States.casa_caminho_dir;

		}  else if (Input.GetKeyDown (KeyCode.V)) {
		    myState = States.entrada_residencia;
		}
		}

	void Start2 ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.start];

		text.text = "Você voltou para a frente da casa.\n\n" +
			"Aperte <b>C</b>  para para tentar entrar pela porta da frente da casa. \n" +
			"Aperte <b>E</b> para ir para o caminho da esquerda da casa. \n" +
			"Aperte <b>D</b> para ir para o caminho da direita da casa. \n" +
			"Aperte <b>V</b> para voltar para onde seus amigos estavam e desisitir de tudo isso. \n";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.casa_hall;

		} else if (Input.GetKeyDown (KeyCode.E)) {
		    myState = States.casa_caminho_esq;

		}  else if (Input.GetKeyDown (KeyCode.D)) {
		    myState = States.casa_caminho_dir;

		}  else if (Input.GetKeyDown (KeyCode.V)) {
		    myState = States.entrada_residencia;
		}
		}

		void Casa_hall ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.hall];

		text.text = "Estranhamente a porta estava um pouco entre aberta, quase um convite para entrar. " +
		"Uma casa bem velha, de madeira, muitas teias de aranha, muito pó e iluminada apenas com a luz das janelas. " +
		"Porém por ser uma noite de lua cheia não era muito difícil de se enxergar, até mesmo lá dentro. \n" +
		"Logo a sua frente estava uma escada que levava ao segundo andar da casa, estava tudo muito silêncioso, mas a esquerda " +
		"é possível ouvir um chiado que parece ser de uma TV ou um rádio. E a sua frente, um pouco mais a direita, logo a baixo da escada, " +
		"há uma porta, dela emana um cheiro de podridão que chega até mesmo a embrulhar o estômago \n\n" +
		"Aperte E para subir a escada. \n" +
		"Aperte S para se dirigir a sala da esquerda. \n" +
		"Aperte C para ir em direção a porta em baixo da escada. \n" +
		"Aperte V para voltar para voltar para a frente da casa. \n";

		if (Input.GetKeyDown (KeyCode.E)) {
			
			myState = States.segundo_andar;

		} else if (Input.GetKeyDown (KeyCode.V) && janelaLobo == true) {

			myState = States.start;


		} else if (Input.GetKeyDown (KeyCode.V) && janelaLobo == false) {

			myState = States.trancado;

		} else if (Input.GetKeyDown (KeyCode.S)) {

			myState = States.sala_de_estar;

		} else if (Input.GetKeyDown (KeyCode.C)) {

			myState = States.cozinha;

		}

	}

	void Trancado ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.hall];

		text.text = "Depois que você passou, bateu um grande vento e fechou a porta com tudo. "+
		"A porta agora parece estar enterrada. \n\n"+
			"Aperte V para voltar";

			if (Input.GetKeyDown (KeyCode.V)){

			myState = States.casa_hall;
		}

	}

	void Sala_de_Estar ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.sala];

		text.text = "Você chegou ao que parece ser uma sala de estar. Há uma tv velha de tubo ligada apenas com estática. " +
		"Em frente a tv tem um senhor sentado em uma cadeira de rodas, ele não parece te notar. Logo mais a frente, em um canto escuro da sala, " +
		"temos uma porta próxima de um sofá velho e mofado.\n\n" +
		"Aperte T para ir até próximo da TV onde está o velho.\n" +
		"Aperte P para ir até a porta próxima do sofá. \n" +
		"Aperte V para voltar para a próximo da escada.";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.casa_hall;

		} else if (Input.GetKeyDown (KeyCode.T)) {

			myState = States.cadeira_de_rodas;

		} else if (Input.GetKeyDown (KeyCode.P)) {

			myState = States.escada2;
		}

	}

	void Sala_de_Estar2 ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.sala];

		text.text = "Você chegou ao que parece ser uma sala de estar. Há uma tv velha de tubo ligada apenas com estática. " +
		"Parece estar tudo bagunçado, fora do lugar, com diversos arranhões e uma janela quebrada. Logo mais a frente, em um canto escuro da sala, " +
		"temos uma porta próxima de um sofá velho e mofado.\n\n" +
		"Aperte T para ir até próximo da TV.\n" +
		"Aperte P para ir até a porta próxima do sofá. \n" +
		"Aperte V para voltar para a próximo da escada.";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.casa_hall;

		} else if (Input.GetKeyDown (KeyCode.T)) {

			myState = States.cadeira_de_rodas;

		} else if (Input.GetKeyDown (KeyCode.P)) {

			myState = States.escada2;
		}
	}

	void Segundo_Andar ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.corredor1];

		text.text = "Enquanto você subia as escadas, podia ouvir o ranger de cada degrau de madeira. Você está em um grande corredor com uma janela ao final que dá acesso "+
			"a outro corredor a direita. No corredor que você está atualmente existem 2 portas, uma que tem um tapete em frente a porta e outra porta de madeira aparentemente normal. \n\n"+

			"Apete N para entrar na porta normal de madeira. \n"+
			"Aperte B para entrar na porta com o tapete. \n"+
			"Aperte C para entrar no próximo corredor.\n"+
			"Aperte V para descer as escadas e voltas";

			if (Input.GetKeyDown (KeyCode.V)){

			myState = States.casa_hall;

		} else if (Input.GetKeyDown (KeyCode.N)){

			myState = States.quarto_telefone;

		} else if (Input.GetKeyDown (KeyCode.B)){

			myState = States.banheiro;

		} else if (Input.GetKeyDown (KeyCode.C)){

			myState = States.corredor;
		}
		}

		void Corredor ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.corredor2];

		text.text = "Quase um corredor sem saída, se não fosse pelo fato da porta logo ao fundo, uma porta de madeira bem antiga, cheia de grandes arranhões.\n\n" +
		"Aperte P para entrar na porta. \n" +
		"Aperte V para voltar.\n";

		if (Input.GetKeyDown (KeyCode.P)) {

			myState = States.quarto_velha;

		} else if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.segundo_andar;
		}
	}

	void Quarto_Velha (){


		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "É um quarto bem confortável, com uma grande cama no meio cheia de cobertas, uma lareira acessa e quente, uma grande janela ao fundo que dá para a "+
		"frente da casa. Deitada na cama temos uma pequena e velha senhora, com um pijama branco e cabelos bem grisalhos. Ela sorri gentilmente para você e diz: Se "+
		"aproxime criança.\n\n"+
		"Aperte J para ir para a janela. \n"+
		"Aperte C para ir para próximo da cama. \n"+
		"Aperte V para sair do quarto. \n";

		if (Input.GetKeyDown (KeyCode.J)) {

			janelaLobo = true;
			myState = States.janela;

		} else if (Input.GetKeyDown (KeyCode.C)) {

			myState = States.cama;

		}  else if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.corredor;
		}

	}

	void Janela ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "Ao se aproximar da janela e olhar para baixo, você nota que algo saiu correndo de dentro da casa em direção a floresta. Parecia ser um tipo de " +
		"lobo gigante.\n\n"+

		"Aperte C para ir para próximo da cama. \n"+
		"Aperte V para sair do quarto.";

		if (Input.GetKeyDown (KeyCode.C)) {

			myState = States.cama;

		} else if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.corredor;
		}

	}

	void Janela2 ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "Ao se aproximar da janela você escuta um uivo vindo da floresta.\n\n"+

		"Aperte C para ir para próximo da cama. \n"+
		"Aperte V para sair do quarto.";

		if (Input.GetKeyDown (KeyCode.C)) {

			myState = States.cama;

		} else if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.corredor;

		}
	}

	void Cama(){

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "Não tenha medo, não tenha medo criança. Diz ela enquanto se arruma na cama. Do lado dela, na cama, parece ter algum tipo de cordão com uma chave. "+
		"O que faz aqui? Completa ela ao terminar de se arrumar?\n\n"+
		"Aperte V para de aproximar mais da cama e dizer: Vim te visitar é claro.\n"+
		"Aperte P para dizer: Eu me perdi...";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.cama2;

		} else if (Input.GetKeyDown (KeyCode.P)) {

			contador +=1;
			myState = States.cama3;
		}

	}

	void Cama_Chave(){

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "Já conseguiu o que foi pegar docinho?\n\n"+
		"Aperte Q para dizer: Quase.\n";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.quarto_velha;

		}

	}

	void Cama2(){

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "Que bom, adoro visitas, você é um amor.\n\n"+
		"Aperte V para de aproximar mais da cama e dizer: Onde está o vovô?\n"+
		"Aperte O para dizer: Que olhos grandes...";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.cama4;

		} else if (Input.GetKeyDown (KeyCode.O)) {

			contador +=1;
			myState = States.cama5;

		}
	}

	void Cama3(){

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "Pobre criança, não se preocupe, agora tudo ficará bem...\n\n"+
		"Aperte V para de aproximar mais da cama e dizer: Onde está o vovô?\n"+
		"Aperte O para dizer: Que olhos grandes você tem...";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.cama4;

		} else if (Input.GetKeyDown (KeyCode.O)) {

			contador +=1;
			myState = States.cama5;

		}
	}

	void Cama4(){

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "Meu amor, o seu avó provavelmente está lá em baixo assistindo TV...\n\n"+
		"Aperte L para de aproximar mais da cama e dizer: Vovó e nosso livro, você lembra onde ele está?\n"+
		"Aperte O para dizer: Vovó, que orelhas pontudas você tem...";

		if (Input.GetKeyDown (KeyCode.L)) {

			myState = States.cama6;

		} else if (Input.GetKeyDown (KeyCode.O)) {

			contador +=1;
			myState = States.cama7;

		}

	}

	void Cama5(){

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "São pra te ver melhor, docinho...\n\n"+
		"Aperte L para de aproximar mais da cama e dizer: Vovó e nosso livro, você lembra onde ele está?\n"+
		"Aperte O para dizer: Vovó, que orelhas pontudas você tem...";

		if (Input.GetKeyDown (KeyCode.L)) {

			myState = States.cama6;

		} else if (Input.GetKeyDown (KeyCode.O)) {

			contador +=1;
			myState = States.cama7;

		}
	}

	void Cama6(){

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "Hmm, não consigo me lembrar muito bem, minha cabeça hoje não está tão boa, deve ser essa noite que está mexendo comigo. Porão... talvez...\n\n"+
		"Aperte L para de aproximar mais da cama e tentar pegar a chave.\n"+
		"Aperte O para dizer: Vovó, que dentes grandes você tem...";

		if (Input.GetKeyDown (KeyCode.L)) {

			myState = States.cama8;

		} else if (Input.GetKeyDown (KeyCode.O)) {

			contador +=1;
			myState = States.cama9;
		}
	}

	void Cama7(){

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "São pra te ouvir melhor, meu amor...\n\n"+
		"Aperte L para de aproximar mais da cama e tentar pegar a chave.\n"+
		"Aperte O para dizer: Vovó, que dentes grandes você tem...";

		if (Input.GetKeyDown (KeyCode.L)) {

			chave = true;
			ichave.SetActive(true);

			myState = States.cama9;

		} else if (Input.GetKeyDown (KeyCode.O)) {

			contador +=1;
			myState = States.cama_morte;

		}
	}

	void Cama8(){

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "Acho que estou começando a ficar com fome...\n\n"+
		"Aperte L para dizer: Não se preocupe vovó, vou descer na cozinha e pegar algo para comermos, logo logo estarei de volta.\n"+
		"Aperte O para dizer: Vovó, que dentes grandes você tem...";

		if (Input.GetKeyDown (KeyCode.L)) {

			ichave.SetActive(true);

			chave = true;
			myState = States.cama9;

		} else if (Input.GetKeyDown (KeyCode.O)) {

			myState = States.cama_morte;

		}
	}
	void Cama9(){

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "Tudo bem meu anjo, mas não demore...\n\n"+
		"Aperte L para dizer: Não se preocupe vovó, vou descer na cozinha e pegar algo para comermos, logo logo estarei de volta.\n"+
		"Aperte O para dizer: Vovó, que dentes grandes você tem...";

		if (Input.GetKeyDown (KeyCode.L)) {

			myState = States.corredor;

		} else if (Input.GetKeyDown (KeyCode.O)) {

			myState = States.cama_morte;
		}
	}

	void Cama_Morte ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto];

		text.text = "São pra te comer melhor! Diz ela enquanto começa a arrancar os pedaços de sua própria carna com as mãos, quase como arrancando uma pele falsa "+
		"que estivesse por cima. Seus ossos vão estalando super alto e mudando de forma, dentes, unhas, olhos, tudo parece bem maior agora. E com um grande rugido ela pula "+
		"na sua direção, cravando suas longas garras nas suas costelas e mordendo a sua julgular. Conforme ela aperta com toda sua força, você pode ver seus grandes "+
		"olhos amarelos fixados no seu, olhando a vida se esvair pelo seu olhar...\n\n"+

		"Aperte D para continuar...";

		if (Input.GetKeyDown (KeyCode.D)) {

			myState = States.morte;
		}
	}

	void Quarto_Telefone ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto_telefone];

		text.text = "É um quarto completamente vazio, apenas com uma janela e o que parece ser uma lata vazia com uma linha, em que uma ponta da linha está presa a parede " +
		"e a outra está presa a lata.\n\n" +

		"Aperte L para pegar a lata na mão. \n" +
		"Aperte V para sair do quarto.";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.segundo_andar;

		} else if (Input.GetKeyDown (KeyCode.L)) {

			myState = States.lata;
		}
		}

		void Banheiro ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.banheiro];

		text.text = "Você está no banheiro, não parece ter nada muito anormal por aqui, tirando o fato dele estar bem sujo, no fundo do banheiro temos uma banheira cheia "+
		"e logo atŕas uma grande janela. Então você escuta o que seriam batidas na janela, seria até normais, isso se você não estivesse no segundo andar da casa.\n\n"+
		"Aperte J para olhar a janela. \n"+
		"Aperte V para voltar para sair do banheiro.";

		if (Input.GetKeyDown (KeyCode.J)) {

			myState = States.espelho;

		} else if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.segundo_andar;

		}

	}

		void Espelho ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.banheiro];

		text.text = "Você se aproxima da janela, quando na verdade nota que as batidas não vem dela e sim do espelho. Ao olhar para o espelho, diversas mãos começam a " +
		"surgir do outro lado. Então você percebe que na verdade todas aquelas mãos percebem a uma mesma criatura do outro lado, com um grande sorriso cheio de dentes. " +
		"Todas as mãos saem juntas e te puxam extreamente rápido para dentro, silêncio é tudo o que sobra...\n\n" +
		"Aperde D...";

		if (Input.GetKeyDown (KeyCode.D)) {

			myState = States.morte;

		}
	}

		void Lata ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.quarto_telefone];

		text.text = "No momento em que você pega a lata na mão, escuta uma voz vindo dela e dizendo: O..la...tem alguém...ai?\n\n"+
		"Aperte S para responder sim. \n"+
		"Aperte N para não dizer nada e largar a lata no chão.";

		if (Input.GetKeyDown (KeyCode.S)) {

			myState = States.lata2;

		} else if (Input.GetKeyDown (KeyCode.N)) {

			myState = States.quarto_telefone;

		}
	}

	void Lata2 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.quarto_telefone];

		text.text = "Finalmente um...visitante, hmm... sobre o que gostaria de conversar?\n\n"+
		"Aperte Q: Que lugar é este?. \n"+
		"Aperte C: Como eu saio daqui?.\n"+
		"Aperte W: Quem é você? \n"+
		"Aperte V: Voltar e não perguntar mais nada.";

		if (Input.GetKeyDown (KeyCode.Q)) {

			myState = States.lata3;

		} else if (Input.GetKeyDown (KeyCode.C)) {

			myState = States.lata4;

		} else if (Input.GetKeyDown (KeyCode.W)) {

			myState = States.lata5;

		} else if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.quarto_telefone;
		}
	}

	void Lata3 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.quarto_telefone];

		text.text = "Que lugar é este? Hmm... esta é uma pergunta um pouco complexa de se responder, acho que a pergunta mais completa seria dizer que aqui é " +
		"a lacuna entre a loucura e a insanidade. O ultimo lugar para alguém como você... ou não, hahaha.\n\n" +
		"Aperte V: para voltar. \n";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.lata2;
		}
	} 

	void Lata4 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.quarto_telefone];

		text.text = "Todos que vem aqui perguntam a mesma coisa... Mas só existe uma resposta para isto, a morte. O que foi? Ahh entendi, você quer sair vivo. " +
		"Hahaha, não fique assim, não se pode mais nem brincar nos tempos de hoje, a resposta é simples, o livro.\n\n" +
		"Aperte V: para voltar. \n";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.lata2;
		}
	} 

	void Lata5 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.quarto_telefone];

		text.text = "Pergunta errada... deveria estar se perguntando quem é você. Afinal eu nem existo.\n\n " +
		"Aperte V: para voltar. \n";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.lata2;
		}
	} 

	void Cozinha ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.cozinha];

		text.text = "Parece ser um tipo de cozinha, o cheiro de carne podre é insuportável. Temos uma grande mesa de madeira ao centro, não dá pra ver ao certo o que é. " +
		"Logo atrás da mesa mais a direita, temos uma porta e mais a esquerda da mesa temos um balcão com diversos utensilios e o que parece ser uma pia.\n\n" +

		"Aperte B para ir para próximo do balcão. \n" +
		"Aperte M para ir para próximo da mesa. \n" +
		"Aperte P para ir para a porta.\n" +
		"Aperte V para voltar.";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.casa_hall;

		} else if (Input.GetKeyDown (KeyCode.B)) {

			myState = States.balcao;

		} else if (Input.GetKeyDown (KeyCode.M)) {

			myState = States.mesa;

		} else if (Input.GetKeyDown (KeyCode.P)) {

			myState = States.quintal;
		}
	}

	void Cozinha2 ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.cozinha];

		text.text = "Parece ser um tipo de cozinha, o cheiro de carne podre é insuportável. Temos uma grande mesa de madeira ao centro, não dá pra ver ao certo o que é. " +
		"Logo atrás da mesa mais a esquerda, temos uma porta e mais a direita da mesa um balcão com diversos utensilios e o que parece ser uma pia.\n\n" +

		"Aperte B para ir para próximo do balcão. \n" +
		"Aperte M para ir para próximo da mesa. \n" +
		"Aperte P para ir para a porta.\n" +
		"Aperte V para voltar.";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.quintal;

		} else if (Input.GetKeyDown (KeyCode.B)) {

			myState = States.balcao;

		} else if (Input.GetKeyDown (KeyCode.M)) {

			myState = States.mesa;

		} else if (Input.GetKeyDown (KeyCode.P)) {

			myState = States.casa_hall;
		}
	}

	void Mesa ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.cozinha];

		text.text = "Quando você se aproxima da mesa, finalmente percebe de onde vem todo aquele cheiro. São dos diversos pedaços em decomposição em cima dela, " +
		"uma cena que é de embrulhar o estômago. Braços, pernas e outras diversas partes humanas em cima daquela mesa de madeira, isso tudo mistulado com diversos " +
		"pedaços de o que parecem ser porcos. Um dos braços humanos parece estar segurando uma lanterna. \n\n" +
		"Aperte P para pegar a lanterna. \n" +
		"Aperte V para se afastar da mesa. \n";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.cozinha;

		} else if (Input.GetKeyDown (KeyCode.P)) {
			lanterna = true;
			ilanterna.SetActive(true);
		    myState = States.cozinha;

		}
	}

	void Balcao ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.cozinha];

		text.text = "Você chega mais próximo do balcão, há diversos tipos de utensilios de cozinha, facas, panelas, todos enferrujados. \n\n" +

		"Aperte F para pegar uma faca. \n"+
		"Aperte V para se afastar do balcão";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.cozinha;

		} else if (Input.GetKeyDown (KeyCode.F)) {

			myState = States.cozinheiro;
		}
	}

	void Cozinheiro ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.cozinha];

		text.text = "No momento em que você vai pegar uma faca, algo surge atrás de você, quando você se vira para olhar sua visão automaticamente sobe. " +
		"Parece ter no minimo 2 metros de altura, grande e gordo, com um avental de cozinheiro totalmente sujo, uma máscara que parece ter sido custurada com a face " +
		"de um porco e um grande cutelo na mão direita. Antes que você pudesse ter quaquer reação, ele ergueu rapidamente seu braço direito e com toda força e velocidade " +
		"acertou o meio da sua cabeça. A única coisa que você sentiu nesse momento, foram suas mãos levemente tremulas, sua boca levemente aberta " +
		" e o sangue da sua cabeça escorrendo pelo seu rosto a ponto de cobrir seus olhos e tudo começar a ficar preto. \n\n" +
		"Aperte D para continuar...";

		if (Input.GetKeyDown (KeyCode.D)) {

			myState = States.morte;
		}
	}

	void Mesa2 ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.cozinha];

		text.text = "Diversos pedaços em decomposição em cima da mesa, " +
		"uma cena que é de embrulhar o estômago. Braços, pernas e outras diversas partes humanas em cima daquela mesa de madeira, isso tudo mistulado com diversos " +
		"pedaços de o que parecem ser porcos. \n\n" +
		"Aperte V para se afastar da mesa. \n";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.cozinha;
		}
	}

	void Quintal (){

		Imagem.sprite = myArrayImage[(int)ImageStates.quintal];

		text.text = "A porta te leva até um grande quintal dos fundos. "+
		"Você chega a parte de trás da casa. Quase ao lado da porta temos um caminho estreito de terra que segue pela lateral da casa. " + 
		"No quintal também  é possível ver um pequeno parquinho com uma caixa de areia e 2 balanços. Logo ao lado disso temos um pequeno "+
		"cemitério e mais ao fundo de tudo é possível ouvir o som do mar.\n\n "+
			
			"Aperte M para ir para onde está vindo o barulho do mar. \n" +
			"Aperte P para ir ao parquinho. \n" + 
			"Aperte C para ir ao cemitério. \n" + 
			"Aperte E para ir pelo caminho estreito. \n" + 
			"Aperte V para voltar para voltar para dentro da casa. \n";

 		if (Input.GetKeyDown (KeyCode.E)) {

 		myState = States.start2;
 		 
		} else if (Input.GetKeyDown (KeyCode.V)) {

 		myState = States.cozinha;

		} else if (Input.GetKeyDown (KeyCode.C)) {

 		myState = States.cemiterio;

		} else if (Input.GetKeyDown (KeyCode.M)) {

 		myState = States.praia;

		} else if (Input.GetKeyDown (KeyCode.P)) {

 		myState = States.parquinho;

		}

	}

	void Praia ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.cut_praia];


		text.text = "Você caminha até a ponta de um desfiladeiro, parece ter uns 30 metrôs de altura. Logo abaixo temos uma pequena praia e em seguida o mar. " +
		"Uma tempestade parece estar se aproximando, diversos relampagos começam a se propagar pelos céus. Você escuta um estrondoso barulho, ensurdecedor. " +
		"Até que você nota que algo gigantesco começa a se levantar do mar. É uma criatura inexplicável e gigantesca, humanoide, com diversos tentáculos no rosto e grandes olhos " +
		"vermelhos. Ele finalmente fica em pé e se aproxima do desfiladeiro que você está. Você está paralizado, não consegue mover 1 musculo, é quase hipnotizante. " +
		"Quando finalmente ele torna os olhos para você e lentamente estica mão em sua direção. Então você simplesmente explode em vários pedaços, espalhando seu sangue em " +
		"várias direções.\n\n" +

		"Aperte D para continuar...";

		if (Input.GetKeyDown (KeyCode.D)) {

			myState = States.morte;

		}
	}

	void Praia2 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.cut_praia];

		text.text = "Como em um passe de mágina, você está fora da casa. Você caminha até a ponta de um desfiladeiro, parece ter uns 30 metrôs de altura."+
		"Logo abaixo temos uma pequena praia e em seguida o mar. " +
		"Uma tempestade parece estar se aproximando, diversos relampagos começam a se propagar pelos céus. Você escuta um estrondoso barulho, ensurdecedor. " +
		"Até que você nota que algo gigantesco começa a se levantar do mar. É uma criatura inexplicável, gigantesca, humanoide, com diversos tentáculos no rosto e grandes olhos " +
		"vermelhos. Ele finalmente fica em pé e se aproxima do desfiladeiro que você está. É quase hipnotizante, " +
		"quando finalmente ele torna os olhos para você: Você finalmente consegue me ouvir, minha criança. Não se preocupe, agora enquanto você me servir, tudo que seus olhos tocarem " +
		"será seu. E assim uma nova era se inicia, o que será que essas escolhas trarão para o futuro? Isso é algo que só descobriremos em outra história...\n\n" +

			"Aperte C para continuar";

		if (Input.GetKeyDown (KeyCode.C)) {
	  	
			myState = States.fim;
		}
	}

	void Cemiterio ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.cemiterio];

		text.text = "É realmente um cemitério, temos lápides, algumas covas abertas e também alguns poucos caixões de madeira. Mas o que estaria fazendo um " +
		"cemitério nos fundos de uma casa? Antes que pudesse se perguntar mais qualquer coisa, algo acerta sua cabeça e você desmaia. Acorda lentamente, desorientado, " +
		"não dá para saber quanto tempo se passou, você parece estar deitado em algum tipo de buraco, e terra começa a ser jogada em cima de você. Por causa da pancada " +
		"e da quantidade de terra que já tem em cima de você, não consegue ter forças pra se levantar, pouco a pouco seus gritos são abafados pela terra.\n\n" +

		"Aperte D para continuar...";

		if (Input.GetKeyDown (KeyCode.D)) {

			myState = States.morte;		   	
		}
	}

	void Parquinho ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.parquinho];

		text.text = "Um pequeno parquinho, com uma pequena caixa de areia e um balanço com 2 lugares, próximo a isso temos um toco de maderia com um machado infincado.\n\n" +

		"Aperte M para pegar o machado. \n" +
		"Aperte V para se afastar do parquinho";

		if (Input.GetKeyDown (KeyCode.M)) {


			machado = true;
			imachado.SetActive(true);
			myState = States.quintal;

 		 
		} else if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.quintal;
		}

	}

	void Parquinho2 ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.parquinho];

		text.text = "Um pequeno parquinho, com uma pequena caixa de areia e um balanço com 2 lugares, próximo a isso temos um toco de maderia sujo de sangue.\n\n" +

		"Aperte V para se afastar do parquinho";

		 if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.quintal;
		}
	}

	void Cadeira_de_Rodas ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.sala];

		text.text = "Você se aproxima lentamente do velho sentado na cadeira de rodas, quando nota que ele está olhando fixamente para a TV " +
		"sem imagem, apenas aquela tela cheia de estátita, ele está com os olhos abertos, olhando sem piscar, a boca está levemente aberta, parece " +
		"que ele pode babar a qualquer instante. Não parece que ele vá te responder qualquer coisa. Próximo a ele, a uma pequena mesinha com o um " +
		"cinzeiro, alguns cigarros apagados e próximo a isso um isqueiro prateado. \n\n" +

		"Aperte I para pegar o isqueiro.\n"+
		"Aperte V para voltar";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.sala_de_estar;
		} else if ((Input.GetKeyDown (KeyCode.I) && isqueiro == false)) {

			isqueiro = true;
			iisqueiro.SetActive(true);
			myState = States.sala_de_estar;
		}
	}

		void Cadeira_de_Rodas2 ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.sala];

		text.text = "Você se aproxima lentamente do velho sentado na cadeira de rodas, quando nota que ele está olhando fixamente para a TV " +
		"sem imagem, apenas aquela tela cheia de estátita, ele está com os olhos abertos, olhando sem piscar, a boca está levemente aberta, parece " +
		"que ele pode babar a qualquer instante. Não parece que ele vá te responder qualquer coisa. \n\n" +

		"Aperte V para voltar";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.sala_de_estar;
		}
	}

	void Cadeira_de_Rodas3 ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.sala];

		text.text = "sem imagem, apenas aquela tela cheia de estátita. Próximo a ela, a uma pequena mesinha com o um " +
		"cinzeiro, alguns cigarros apagados e próximo a isso um isqueiro prateado. \n\n" +

		"Aperte I para pegar o isqueiro.\n"+
		"Aperte V para voltar";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.sala_de_estar;
		} else if ((Input.GetKeyDown (KeyCode.I) && isqueiro == false)) {

			isqueiro = true;
			iisqueiro.SetActive(true);
			myState = States.sala_de_estar;
		}
	}

	void Cadeira_de_Rodas4 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.sala];

		text.text = "Sem imagem, apenas aquela tela cheia de estátita. \n\n" +

		"Aperte V para voltar";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.sala_de_estar;
			}
	}

	void Escada2 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.porao_escada];

		text.text = "Você dá de encontro para uma escada de madeira, que desce parecendo levar para o porão da casa. Diferente dos outros comodos " +
		"este realmente não dá para enxergar praticamente nada. Não há nenhum tipo de enterrupitor ou qualquer coisa que permita ligar uma luz. \n\n" +

		"Aperte V para voltar.\n"+
		"Aperte D para descer as escada.";

		if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.sala_de_estar;

		} else if (Input.GetKeyDown (KeyCode.D)) {

			myState = States.porao;
	}
	}

	void Porao ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.escada_sem_lanterna];

		text.text = "Você começa a descer lentamente as escadas. Você mal consegue enxergar um palmo a sua frente. "+
		"Você continua descendo até que chega em um ponto em que seus pés tocam a água. A água fica até a altura dos seus calcanhares. "+
		"Você escuta algo correndo pela água, olha em volta, mas nada vê. Então mais uma vez você escuta algo passando por trás de você. "+
		"É muito rápido para de acompanhar, a única coisa que você consegue fazer é ficar praticamente girando em circulos. Cada momento "+
		"você escuta em um lado diferente. Até que tudo para... Então quando finalmente você teve um tempo para respirar profundamente. "+
		"Algo te derruba na água e pula em cima de você, tentando te afogar. Você não consegue fazer nada, quanto mais tenta reagir mais "+
		"parece que fica preso no que parecem ser longos cabelos. Então lentamente vai perdendo suas forças, até o ponto em que a ultima coisa "+
		"que vê, são as suas ultimas bolhas de ár...\n\n"+

		"Aperte D para continuar...";

		if (Input.GetKeyDown (KeyCode.D)) {

			myState = States.morte;
		}
	}

	void Porao2 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.porao];


		text.text = "Você liga sua lanterna e começa a descer lentamente as escadas. Você ilumina mais abaixo, e algo parece estar lá. "+
		"Você continua descendo até que chega em um ponto em que seus pés tocam a água. A água fica até a altura dos seus calcanhares. "+
		"Você então ilumina em volta com sua lanterna, parece ser um velho porão, com água espalhada por todo o chão, e longas vigas emprodrecidas "+
		"que parecem sustentar toda a casa. Então, em um canto escondido, você ilumina algo com a lanterna, parece ser uma pequena menina, pálida, com "+
		"um vestido branco e longos cabelos pretos, tão longos que chegam a tocar a água no chão. Qualquer tipo de comunicação com ela parece ser ineficaz. "+
		"Ela sempre foge ao ver a luz, e se esconde em outro canto escuro. Mas continua a espreita, apenas observando, aguardando..."+
		"Nesse mesmo local temos uma segunda escada de madeira, praticamente igual a que você acabou de descer e em uma das paredes do porão, temos um local "+
		"com um grande X vermelho marcado. \n\n"+

			"Aperte E para subir a segunda escada\n"+
			"Aperte P para se aproximar da parede\n"+
			"Aperte V para voltar para a sala";

		if (Input.GetKeyDown (KeyCode.E)) {

			myState = States.casa_caminho_esq;

		} else 	if (Input.GetKeyDown (KeyCode.P)) {

			myState = States.parede_x;

		} else 	if (Input.GetKeyDown (KeyCode.P)) {

			myState = States.sala_de_estar;
		}
	}

	void Porao3 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.porao];

		text.text = "Temos duas escadas para subir, a primeira que te leva até a sala de estar e a segunda\n\n"+
		"Aperte S para subir a segunda escada.\n"+
		"Aperte X para voltar a parede. \n"+
		"Aperte V para subir a escada e voltar a sala de estar.";

		if (Input.GetKeyDown (KeyCode.S)) {

			myState = States.caminho_esq2;

		} else 	if (Input.GetKeyDown (KeyCode.X)) {

			myState = States.parede_x;

		} else 	if (Input.GetKeyDown (KeyCode.V)) {

			myState = States.sala_de_estar;
		}
	}

	void Parede_X ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.porao];

		text.text = "Uma parede de madeira, está claramente pobre de humida. Com um grande X marcado nela, parece ter sido feito com sangue. \n\n" +
		"Aperte X para tentar derrubar a parede.\n" +
		"Aperte V para voltar";	  

		if (Input.GetKeyDown (KeyCode.X) && machado == true) {

			myState = States.parede_cai;

		} else if (Input.GetKeyDown (KeyCode.X) && machado == false) {

			myState = States.parede_nao_cai;
		}
	}

	void Parede_Cai ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.porao];

		text.text = "Apersar de você não ter muita força, a madeira estar podre te ajuda bastante e com poucas machadadas você consegue derruba-la." +
		"depois do pó baixar, você acaba encontrando outro comodo da casa, este está bem mais iluminado. Há um altar no centro dessa sala. Com um grande " +
		"livro em cima. \n\n" +
		"Aperte L para pegar o livro. \n" +
		"Aperte V para voltar.";

		if (Input.GetKeyDown (KeyCode.L)) {
			livro = true;
			ilivro.SetActive(true);
			myState = States.pegou_livro;
		}

	  if (Input.GetKeyDown (KeyCode.V)) {
	  	
	  	myState = States.porao3;
		}
	}

	void Parede_Nao_Cai ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.porao];

		text.text = "Apesar de estar claramente podre, ainda é muito resistente para ser derrubada tão facilmente. Você irá precisar mais do que isso " +
		"para conseguir derruba-la.\n\n" +
		"Aperte V para voltar";

		if (Input.GetKeyDown (KeyCode.V)) {  	
			myState = States.porao3;
		}
	}

	void Pegou_Livro ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.livro_altar];

	 text.text = "É um grande livro velho, com uma capa de couro bem robusta, está com uma especie de tranca. É necessário abri-lo para destrui-lo. Você não sabe ao "+
	 "certo porque, se é pela capa de couro resistente ou pela mágia negra em volta dele...\n\n"+
	 "Aperte A para tentar abri-lo. \n"+
	 "Aperte V para voltar.\n";

		if (Input.GetKeyDown (KeyCode.V)) {  	
	  	myState = States.porao3;

		} else if (Input.GetKeyDown (KeyCode.A) && chave ==true) { 	
	  	myState = States.livro_aberto;

		} else if (Input.GetKeyDown (KeyCode.A) && chave ==false) {
	  	myState = States.livro_fechado;
		}
	}

	void Livro_Aberto ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.livro_altar];

		text.text= "Parecem ter várias páginas sobre diversos seres mitologicos e outros que nem passavam pela sua imaginação. Rituais, feitiços, artefatos. "+
		"A questão agora é, qual será a sua escolha?\n\n"+

		"Aperte B para queimar o livro\n"+
		"Aperte F para ficar com o livro para você";

		if (Input.GetKeyDown (KeyCode.B)) {
	  	
	  	myState = States.livro_queimado;

		} else if (Input.GetKeyDown (KeyCode.F)) {

		livroSeu = true;
		ilivro.SetActive(true);
	  	myState = States.livro_seu;

		}
	}

	void Livro_Queimado ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.livro_altar];

		text.text = "Você começa a queimar o livro com o isqueiro e quase que instantaneamente todo o livro começa a queimar em diversas cores diferentes, azul, verde, roxo... " +
		"Tudo vai se misturando conforme as chamas vão consumindo ele, um forte vento invade o local que você está e páginas começam a voar por todo o lugar. E do nada, tudo para, " +
		"Apenas o vazio e o silêncio preenchem o lugar, você sobe as escadas, não parece ter mais ninguém em casa, apenas uma casa vazia e fantasmagorica, sai pelo jardim, também " +
		"não escuta nada, nem trovões, nem uivos, nem nenhuma pessoa, você caminha até o portão principal da casa. E o que você vê lá te surpreende, são seus amigos te aguardando. " +
		"Já voltou?! Não saiu nem a 5min, sabia mesmo que era um bebê chorão, hahahaha. Diz um deles caçoando de você. Aquilo tudo aconteceu mesmo? Foi real? Você quer acreditar que não, " +
		"mas no seu coração você sabe que aconteceu. Mas também sabe que passou por tudo e venceu. Agora você sabe os segredos e as verdades que cercam esse mundo. De agora em diante " +
		"você é algo novo, você não tem mais o que temer... isso é claro, até a próxima aventura...\n\n" +

		"Aperte C para continuar";

		if (Input.GetKeyDown (KeyCode.C)) { 	
			myState = States.fim;
		}
	}

	void Livro_Queimado2 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.livro_altar];

		text.text = "Você precisa de algo para te ajudar a queimar o livro.\n\n"+
		"Aperte V para voltar.";

		if (Input.GetKeyDown (KeyCode.V)) {
	  	
			myState = States.porao3;
	}
	}

	void Livro_Fechado ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.livro_altar];

		text.text = "Você não consegue, parece que é necessário algum tipo de chave para conseguir abri-lo\n\n" +
		"Aperte V para voltar";

		if (Input.GetKeyDown (KeyCode.V)) {  	
			myState = States.parede_x;
		}
	}

	void Livro_Seu ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.livro_altar];

		text.text = "Por que não ficar com ele não é mesmo? Imagine o que poderá fazer, os poderes que terá. As possibilidades são infinitas, você sabe o que fazer agora "+
		" não sabe? Ele te aguarda, vá ao encontro dele, ele te chama, diz uma voz na sua cabeça. Neste momento você escuta um grande estrondo vindo de trás da casa, parece "+
		"vir do quintal.\n\n"+

		"Aperte C para ir. \n";

		if (Input.GetKeyDown (KeyCode.C)) {	  	
			myState = States.praia;
	}
	}

	void Casa_Caminho_Esq ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.lateralEsq];

		text.text = "Após caminhar um pouco pela lateral da casa, há um muro de pedras a sua esquerda, que tem a altura do seu peito, então é possível "+
		"ver do outro lado. Você começa a enxergar que um jardim vai começando a se formar do outro lado, até que você chega a um pequeno portão "+
		"que leva ao outro lado deste muro. Mas antes disso, a sua direita, há uma porta de madeira ligada ao chão, "+
		"parece ser a entrada do porão da casa.\n\n "+
			
			"Aperte P para entrar no porão. \n" +
			"Aperte J para entrar no Jardim. \n" + 
			"Aperte V para voltar para voltar para a frente da casa.";

 		if (Input.GetKeyDown (KeyCode.V)) {
			myState = States.start;

		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.porao;

		} else if (Input.GetKeyDown (KeyCode.J)) {
			myState = States.jardim;
			}
		}

		void Jardim ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.jd];

		text.text = "Você passa pelo portão e agora está em um pequeno Jardim, com 2 caminhos de pedra, um que leva em direção a floresta e um que tem pequenos pedaços "+
		"de pão, quase migalhas seguindo por esse caminho.\n\n"+
		"Aperte F para ir em direção a floresta. \n"+
		"Aperte M para seguir o caminho de migalhas.\n"+
		"Aperte V para voltar para próximo da casa";

		if (Input.GetKeyDown (KeyCode.F)) {
			janelaLobo = true;
			myState = States.floresta;

		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.migalhas;

		} else if (Input.GetKeyDown (KeyCode.V)) {
			myState = States.caminho_esq2;
			}
		}

		void Migalhas ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.migalhas];

		text.text = "Seguindo por esse caminho, mais a frente você começa a avistar algumas tochas, você fica parcialmente escondido em meio aos arbustos próximos. "+
		"Desse lugar você consegue perceber que temos um campo aberto e várias pedras gigantes em forma de tentáculos formando um circulo e uma pedra no centro de todas "+
		"que parece servir como uma mesa, que está marcada com vários simbolos e com algums cálices dourados em cima.\n\n"+

		"Aperte A para de apróximar das pedras. \n"+
		"Aperte V para voltar para o jardim.";

		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.pedras;

		} else if (Input.GetKeyDown (KeyCode.V)) {
			myState = States.jardim;
		}
	}

	void Floresta ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.floresta1];

		text.text = "Você acabou se perdendo na floresta, ela é muito fechada, com grandes árvores, mal dá para ver o céu, o clima está bem frio e a neblina densa. "+
		"Você pergunta a quanto tempo está andando ali. Até o momento em que você escuta um grande uivo. Você olha em volta, mas não parece achar a direção exata de onde "+
		"veio isso, você então começa a apertar o passo. Algo parece estar a sua espreita, algo parece estar se movendo na floresta, seu coração começa a disparar, sua "+
		"respiração começa a ficar mais pesada. ALGO está ali! Você começa a correr, chega a uma birfurcação, há 2 caminhos, o da esquerda que parece levar para um lago "+
		"e o da direita que tem pedaços de pão parecidos com o que você viu antes de sair do Jardim. \n\n"+
		"Aperte N para ir em direção ao lago. \n"+
		"Aperte M para seguir o caminho de migalhas. \n";

		if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.lago;

		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.migalhas;
		}
	}

	void Lago ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.lago];

		text.text = "Você continua correndo com todas suas forças, até que chega a beira do lago. Quando olha para trás, vê aquela figura atrás de vocês, parece ser um "+
		"logo, mas ao mesmo tempo não, ele é maioor e mais enrugado que um lobo normal, com um pelo parcialmente grisalho, seu focinho pinga de sangue. Mas o mais anormal "+
		"é que suas patas traseiras estão presas a uma espécie de cadeira de rodas. Você tenta corre para o lago, porém antes que tivesse a chance de conseguir entrar completamente "+
		"ele te pega, então sangue começa a se misturar com água enquanto ele te estraçalha completamente.\n\n"+
		"Aperte D para continuar...";

		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.morte;
		}	  
	}

	void Pedras ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.pedras];

		text.text = "Você se aproxima lentamente do centro das rochas e agora consegue ver um pouco melhor os simbolos da pedra. Até que começam a surgir várias pessoas " +
		"da floresta em volta, não importa para qual lado você olhe, surge uma pessoa, todas com mantos vermelhos, capuz e máscaras de madeira em forma de animais. " +
		"No exato momento exato em que você vira seu corpo para correr, sente algo na sua barriga, um dos entegrantes dessa seita enviou uma faca na sua barriga. Logo em " +
		"seguida, todos os outros se aproximaram e todos eles começaram a fazer o mesmo com você, te apunhalando até a morte.\n\n" +
		"Aperte D para continuar...";

		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.morte;
		}
	}
	 void Casa_Caminho_Esq2 ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.lateralEsq];

		 text.text = "Você agora está fora da casa e dá de frente com um portão que parece te levar a um jardim, e também logo mais a sua esquerda há um caminho "+
		 "que parece levar a frente da casa.\n\n"+

			"Aperte J para ir para o jardim. \n"+
			"Aperte E para ir pelo caminho da esquerda. \n"+
			"Aperte V para voltar para o porão.";	

			if (Input.GetKeyDown (KeyCode.J)) {
			myState = States.jardim;

			} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.start2;

			} else if (Input.GetKeyDown (KeyCode.V)) {
			myState = States.porao;
			}
	}

	void Casa_Caminho_Dir ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.lateralDir];

		text.text = "Andando pela lateral esquerda da casa, você percebe que ela contem muitas janelas, mas muitas bloqueadas por tábuas, "+
		"e outras impossíveis de se ver o que tem dentro. " +
		"Um pequeno muro de pedras está a sua direita, então só sobra um pequeno corredor para ir seguindo, que te leva até um grande quintal dos fundos. "+
		"Você chega a parte de trás da casa, onde temos uma porta por onde é possível entrar. " + 
		"No quintal também  é possível ver um pequeno parquinho com uma caixa de areia e 2 balanços. Logo ao lado disso temos um pequeno "+
		"cemitério e mais ao fundo de tudo é possível ouvir o som do mar.\n\n "+
			
			"Aperte E para entrar na casa. \n" +
			"Aperte P para ir ao parquinho. \n" + 
			"Aperte C para ir ao cemitério. \n" + 
			"Aperte M para ir para onde está o barulho do mar. \n" + 
			"Aperte V para voltar para voltar para a frente da casa. \n";

 		if (Input.GetKeyDown (KeyCode.V)) {
 		myState = States.start;

		} else if (Input.GetKeyDown (KeyCode.E)) {
 		myState = States.cozinha2;
 	
		} else if (Input.GetKeyDown (KeyCode.P)) {
 		myState = States.parquinho;

		} else if (Input.GetKeyDown (KeyCode.M)) {
 		myState = States.praia;

		} else if (Input.GetKeyDown (KeyCode.C)) {
 		myState = States.cemiterio;
		}
		}

		void Entrada_Residencia ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.portao];

		text.text = "Você voltou para a entrada da residência, o portão principal, tudo está muito silêncioso, seus amigos não estão mais por lá" +
		"Você chama por eles esperando que seja uma brincadeira, mas ninguém responde " +
		"Será que voltaram para a casa? Será que você deveria fazer o mesmo?" +
		"Você consegue avistar um ponto de ônibus na rua, mas não dá pra enchergar muita coisa, muito alguém caminhando na rua. Uma estranha neblina " +
		"cobre tudo. \n\n" +

		"Aperte V para ir em direção a casa novamente. \n" +
		"Aperta P para ir para o ponto de ônibus. \n" +
		"Aperte R para voltar caminhando pela rua. \n";
		
		if (Input.GetKeyDown (KeyCode.V)) {
			myState = States.start2;

		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.ponto;

		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.rua;
		}
	}

	void Ponto ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.ponto_bus];

		text.text = "Você chega ao ponto de ônibus e uma estranha figura de sobretudo e chapéu está lá também, segurando um grando saco marrom vazio por cima de um dos ombros. "+
		"Ele parece estar esperando também, nem ao menos olha para você. Depois de esperar um pouco, vindo do meio da neblina, finalmente um ônibus grande e vermelho chega."+
		"Você não conhece aquele ônibus, muito menos sabe para onde ele vai. Mas será que é melhor do que ficar ali?\n\n"+
		"Aperte F para ficar no ponto.\n"+
		"Aperte B para entrar no ônibus.";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.ponto_ir;

		} else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.ponto_ficar;
		}
	}

	void Ponto_Ir ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.ponto_bus];

		text.text = "Quando você sobe no ônibus e olha para dentro dele, nota que todos os passageiros estão vestindo roupas muito antigas e nenhum deles tem rosto, nenhum " +
		"olho, boca, nariz, nada. Quando você olha assustado para o motorista, apenas escuta uma risada baixa e calma, seguido das palavras: - O que foi? O lugar para onde " +
		"vamos não é tão ruim assim, e continuou dando sua risada após dizer isto. Nesse exato momento as portas do ônibus se fecham e ele começa a se movimentar.\n\n" +
		"Aperte D para continuar...";

		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.morte;
		}
	}

	void Ponto_Ficar ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.ponto_bus];

		text.text = "Você decide ficar e o ônibus segue em frente. Após algum tempo esperando, você olha para o lado e percebe que o homem está em pé mais próximo de você. " +
		"Depois de mais um tempo, ele está mais próximo ainda, aquilo começa a te incomodar profundamente, você decide se afastar um pouco. " +
		"Outro ônibus começa a se aproximar, de longe o motorista consegue ver uma pessoa no ponto de ônibus. Alguém de sobretudo com um saco marrom por cima no ombro, cheio.\n\n" +
		"Aperte D para continuar...";

		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.morte;
		}
	}

	void Rua ()
	{
		Imagem.sprite = myArrayImage[(int)ImageStates.street];

		text.text = "Você começa a caminhar pela rua, mas a neblida está tão densa que você não consegue enxergar um palmo a sua frente. Você continua caminhando sem saber " +
		"exatamente para onde. Depois de caminhar um pouco, você começa a finalemnte enxergar um pouco melhor e se dá conta de que está em meio a uma grande floresta.\n\n" +

		"Aperte F para continuar na floresta.\n"+
		"Aperte V para tentar voltar para a rua.";

		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.floresta;
		}

		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.entrada_residencia;
		}
	}

	void Fim ()
	{

		Imagem.sprite = myArrayImage[(int)ImageStates.won];
		text.text = "FIM\n\n" +
		"Aperte R para recomeçar.";

		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene(0);
		}
	}

	void Morte() {


		Imagem.sprite = myArrayImage[(int)ImageStates.died];
		text.text = "Você está morto.\n\n"+
		"Aperte R para recomeçar.";

		if (Input.GetKeyDown (KeyCode.R)) {

			SceneManager.LoadScene(0);
	}
	}
	}