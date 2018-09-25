# burgerApp2

Exemplo de aplicação de hamburgeria feito com TDD em .Net Core 2 e Asp.NET MVC

Projetos:

BurgerApp2
Projeto Asp.NET MVC para front-end

BurgerApp2.Domain: Domínio e regras de negócio 
==============================================

Lanche:
Classe representando lanche lista de ingredientes, calculo do valor bruto e valor total (aplicadas as promoções vigentes)

Promocoes:
Strategy de Promocoes onde cada classe possui sua forma de gerar desconto baseado nos ingredientes do lanche

PromocoesVigentes:
Singleton com as promocoes vigentes para serem usadas no cálculo do valor do lanche, para mudá-las é necessário mudar apenas essa classe 

LancheFactory:
Factory de instâncias de lanche para o Cardapio com lanches e valores padrão

CardapioService:
Service para gerar cardapio padrão para tela principal usando DI (dimuindo acoplamento c/ o projeto MVC)


BurgerApp2.Domain.Tests: Testes do Domínio e regras de negócio  
==============================================================

LancheTest:
Testes do calculo de valor de lanches e promoções vigentes

CardapioServiceTest:
Testes do CardapioService
