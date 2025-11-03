const TemplateExpression = () => {
    const nome = "Miguel Morandini";
    const data = {
        age: 20,
        job: "Desenvolvedor de Software",
    };
    return (
        <div>
            <h1>Olá {nome}, seja bem vindo!</h1>
            <p>Você atua como {data.job}</p>
            <p>{4 + 4}</p>
            <p>{console.log ("JSX REACT")}</p>
        </div>
    );
};

export default TemplateExpression;