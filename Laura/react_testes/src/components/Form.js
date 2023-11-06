import styles from './Form.module.css'
import {useState} from 'react'

function Form(){

    function cadastrarUsuario(e){ //mostrar recebimento de dados
        e.preventDefault()
        console.log('Cadastrou o CPF:')
        console.log(cpf)
        console.log('Cadastrou a senha:')
        console.log(password)
    }
    const [cpf, setcpf] = useState()
    const [password, setpassword] = useState()

    return(
        <div className={styles.FormContainer}>
            <h1>Cadastro</h1>
            <form onSubmit={cadastrarUsuario}>
                <div>
                    <label htmlFor="cpf">CPF:</label>
                    <input type="text" id="cpf" name="cpf" placeholder="Digite o seu CPF"
                    onChange={(e)=> setcpf(e.target.value)}
                    />
                    <label htmlFor="password">Senha:</label>
                    <input type="password" id="password" name="password" placeholder="Digite o sua senha"
                    onChange={(e)=>setpassword(e.target.value)}
                    />
                </div>
                <div>
                    <input type="submit" value="Cadastrar"/>
                </div>
            </form>
        </div>
    )
}

export default Form