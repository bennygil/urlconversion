import React from 'react';

export const AppContext = React.createContext();

export class AppProvider extends React.Component {
    constructor(props){
        super(props);
        this.state = {
            page : 'home',
            websites: [],            
            setPage: this.setPage,            
        }
    }
    setPage = page => this.setState({page});    
    componentDidMount = ()=> {}
    
    render(){
        return ( 
            <AppContext.Provider value = { this.state }>
                { this.props.children }
            </AppContext.Provider>
        )
    }
}
