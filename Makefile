# Alvo 'up': Constrói as imagens (se necessário) e sobe os contêineres
.PHONY: up
up:
	@echo "Construindo imagens e iniciando contêineres..."
	docker-compose up --build -d

# Alvo 'down': Para e remove os contêineres
.PHONY: down
down:
	@echo "Parando e removendo contêineres..."
	docker-compose down

# Alvo 'logs': Mostra os logs de todos os serviços (útil para debug)
.PHONY: logs
logs:
	@echo "Exibindo logs... (Pressione Ctrl+C para sair)"
	docker-compose logs -f

# Alvo 'clean': Para, remove e limpa os volumes (CUIDADO: apaga dados do mongo)
.PHONY: clean
clean:
	@echo "Limpando tudo (contêineres e volumes)..."
	docker-compose down -v

# Alvo 'stop': Apenas para os contêineres
.PHONY: stop
stop:
	@echo "Parando contêineres..."
	docker-compose stop

# Alvo padrão (o que acontece se rodar só 'make')
.DEFAULT_GOAL := up