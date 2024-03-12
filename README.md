# Documentação da API

## Solicitar Token
Este endpoint permite solicitar um token de autenticação para acessar outros endpoints da API.

### URL 
```
[POST] https://localhost:7491/api/v1/auth 
```
### Requisição 
A requisição deve conter os seguintes parâmetros no corpo (body) em formato JSON:

```
{
  "username": "",
  "password": ""
}
```

<strong> Token: </strong> O token gerado possui uma duração de 8 horas.

### Resposta de Sucesso 
<strong> Código: </strong> 200 OK </br>
<strong> Conteúdo: </strong> Um token de autenticação.

## Rastrear Pedido
Este endpoint permite rastrear um pedido específico.

### URL 
```
[GET] https://localhost:7491/api/v1/pedido/{endpoint} 
```

### Parâmetros de URL
<strong> endpoint </strong> - O número do pedido que deseja rastrear. Deve conter caracteres 16 ex: XXXXXXXXXXXXX-XX, tipo da variável string.

### Requisição 
Não são necessários parâmetros adicionais no corpo da requisição.

### Resposta de Sucesso 
<strong> Código: </strong> 200 OK </br>
<strong> Conteúdo: </strong> Detalhes do pedido especificado.
