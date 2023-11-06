import {useState} from 'react'
import meuEvento2 from './Evento'
import styles from './Condicional.module.css'
//testando condicional - mostrar email e adicionar um link
function Condicional(){

    const [email,setemail] = useState()
    const [useremail, setuseremail] = useState()

    function enviarEmail(e){
        e.preventDefault()
        setuseremail(email)
        console.log(useremail)
    }
    return(
        <div className={styles.CondicionalContainer}>
            <h1>Cadestre o email</h1>
            <form>
                <input type="email" placeholder='digite seu email' onChange={(e)=> setemail(e.target.value)}/>
                <button type="submit" onClick={enviarEmail}>
                    Enviar-Email
                </button> 

                {useremail && (
                    <div>
                        <p>o email é {useremail}</p>
                        <a href='App2.js' onClick={meuEvento2} >Link</a>
                    </div>
                )}
            </form>
        </div>
    )
}
export default Condicional