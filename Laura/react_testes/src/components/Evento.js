import styles from './Evento.module.css'

//links
function Evento(){

    function meuEvento(){
        console.log("Opa")
    }
    function meuEvento2(){
        console.log("Ops")
    }

    return(
        <div className={styles.EventoContainer}>
        <a href='App2.js' onClick={meuEvento} >Esqueci a senha</a>
        <a href='App2.js' onClick={meuEvento2} >Criar conta</a>
        </div>
    )
}
export default Evento