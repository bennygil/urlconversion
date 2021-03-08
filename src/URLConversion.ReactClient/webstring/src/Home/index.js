import React from 'react';
import Page from '../Shared/Page'
import WebsiteList from './WebsiteList';
import styled from 'styled-components';

const ChartGrid = styled.div`
    display:grid;
    margin-top: 20px;    
    grid-gap: 15px;
    grid-template-columns: 1fr 2fr;
`


export default function(){
    return <Page name='home'>
        <div>
            <h1>Welcome to the Home Page</h1>            
            <ChartGrid>
                <div>Create Component Here</div>
                <WebsiteList/>
            </ChartGrid>
        </div>
    </Page>
    
}