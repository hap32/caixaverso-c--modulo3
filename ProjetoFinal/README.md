# PROJETO FINAL — POO II - Sistema de Pedidos e Pagamentos Extensível

## 1. Objetivo do Projeto
Construir um sistema de criação de pedidos, cálculo de totais, aplicação de descontos e registro de logs utilizando uma arquitetura extensível. O projeto foca no uso de Injeção de Dependência (DI) e na eliminação de estruturas de decisão (`if`/`switch`) espalhadas, seguindo padrões de mercado.

## 2. Estrutura de Pastas
O projeto está organizado conforme os requisitos de entrega:
* **Domain**: Entidades, interfaces de desconto e pagamento.
* **Application**: Processador de pedidos com Template Method.
* **Infrastructure**: Implementações de Logger e Repositório Genérico.

## 3. Regras de Negócio Implementadas
* **Desconto Percentual**: Recebe 10% do Total Bruto.
* **Desconto Por Quantidade**: Se o pedido tiver ≥ 5 itens no total, aplica um desconto fixo de R$ 20,00.
* **Pagamento**: Implementação via Pix e Cartão de Crédito configurável por DI.
* **Polimorfismo**: O sistema suporta novos descontos sem alterar o processador (OCP).

## 4. Instruções de Execução
Para rodar o projeto, utilize o terminal na raiz do diretório:

1. Restore das dependências:
   ```bash
   dotnet restore

## 5. Exemplo de Saída (Cenário Obrigatório)O cenário processa 2 Mouses (R$ 79,90), 1 Teclado (R$ 159,90) e 2 Headsets (R$ 249,90) . A saída no console será:Plaintext[INFO] Total bruto: 818,50
[INFO] Descontos aplicados:
[INFO] DescontoPercentual (10%): 81,85
[INFO] Desconto Por Quantidade: 20,00
[INFO] Total descontos: 101,85
[INFO] Total final: 716,65
[INFO] Pagamento: Pix
[INFO] Status: Pago com sucesso

## 6. Princípios SOLID Aplicados
SRP: Classes com responsabilidades únicas.
OCP: Suporte a novos descontos sem alterar o processador.
DIP: Dependência de abstrações, não de implementações concretas.