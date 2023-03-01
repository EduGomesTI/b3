# b3
Desafio Técnico .Net Cloud B3

## Infraestrutura

Para subir a infra do projeto basta entrar na pasta b3 e usar o seguinte comando:

docker compose up -d

## Configurações

### Dbeaver

http://localhost:8978/

### RabbitMq

http://localhost:15672/
user: guest
pass: guest

### MySQl

host: hostmysql:3306
user: root
password: 1234

## Regras de Negócios

- Ao adicionar uma nova tarefa inserimos a descrição e a data de inclusão é automática, bem com o status de nova tarefa.
- É permitido excluir uma tarefa.
- Não é permitido modificar a descrição ou a data de uma tarefa.
- A tarefa pode ter 4 status:
  - Nova Tarefa
  - Planejada
  - Em andamento
  - Finalizada
- A alteração de status é feita por um microserviço próprio através de mensageria.

## Próximas Atividades

- Impedir que o status de uma tarefa retroceda.
- Melhorar a alteração de status de tarefas.
- Implementar a atualização da descrição de uma tarefa.
