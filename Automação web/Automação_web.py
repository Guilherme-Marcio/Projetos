# 1. Importar as bibliotecas necessárias
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import time
from selenium.webdriver.edge.options import Options

# --- Configurar o navegador para não fechar ---
edge_options = Options()
edge_options.add_experimental_option("detach", True)
# ---------------------------------------------------

# 2. Inicializar o navegador
print("Iniciando o navegador Edge...")
navegador = webdriver.Edge(options=edge_options)

# 3. Abrir a página de login
url = "(URL site)"
print(f"Acessando a URL...")
navegador.get(url)
navegador.maximize_window()

try:
    # --- Preenchimento do formulário ---
    print("Preenchendo e-mail...")
    campo_email_componente = WebDriverWait(navegador, 20).until(
        EC.element_to_be_clickable((By.ID, "email-input")))
    campo_email_componente.click()
    campo_email_componente.send_keys("seu email")
    print("Preenchendo senha...")
    campo_senha_componente = WebDriverWait(navegador, 10).until(
        EC.element_to_be_clickable((By.ID, "password-input")))
    campo_senha_componente.click()
    campo_senha_componente.send_keys("sua senha")
    print("Clicando em Entrar...")
    botao_entrar = WebDriverWait(navegador, 10).until(
        EC.element_to_be_clickable((By.ID, "login-button")))
    botao_entrar.click()
    print("Formulário enviado! Aguardando redirecionamento...")

    # --- Correção da URL ---
    WebDriverWait(navegador, 15).until(
        EC.url_contains("fix de email no caso de erro URL"))
    current_url = navegador.current_url
    if current_url.endswith("/error"):
        correct_url = current_url.removesuffix("/error")
        print(f"Corrigindo URL para: {correct_url}")
        navegador.get(correct_url)
    print("Login efetuado e URL corrigida!")

    # O seletor '.loading-wrapper' identifica a tela de carregamento cinza.
    print("Aguardando a tela de carregamento ('loading') desaparecer...")
    WebDriverWait(navegador, 30).until(
        EC.invisibility_of_element_located(
            (By.CSS_SELECTOR, ".loading-wrapper"))
    )
    print("Tela de carregamento desapareceu! Página pronta.")

    # Acessa o card CENSUP -----------
    print("Procurando o card do chatbot 'CENSUP'...")
    card_do_chatbot = WebDriverWait(navegador, 20).until(
        EC.element_to_be_clickable(
            (By.CSS_SELECTOR, "a[href*='censupauditpria']"))
    )
    print("Card encontrado! Clicando...")
    card_do_chatbot.click()

    print("SUCESSO! Clicado no card do chatbot!")

    # Acessa a aba de atendimentos ---------
    print("Procurando o card de Atendimento ...")
    card_de_atendimento = WebDriverWait(navegador, 20).until(
        EC.element_to_be_clickable((By.CSS_SELECTOR, "a[href*='attendance']"))
    )
    print("Card encontrado! Clicando...")
    card_de_atendimento.click()

    # Acessa o histórico de atendimentos -------
    print("Procurando o Histórico de atendimentos ...")
    card_de_historico = WebDriverWait(navegador, 20).until(
        EC.element_to_be_clickable((By.CSS_SELECTOR, "a[href*='history']"))
    )
    print("Card encontrado! Clicando...")
    card_de_historico.click()


except Exception as e:
    print("ERRO: A automação falhou em algum dos passos.")
    print(f"Detalhes do erro: {e}")

# O script vai terminar aqui
print("Automação finalizada. O navegador permanecerá aberto para interação manual.")
