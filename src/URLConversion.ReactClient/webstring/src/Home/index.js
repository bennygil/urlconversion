import React from 'react';
import Page from '../Shared/Page'
import WebsiteList from './WebsiteList';
import styled from 'styled-components';
import CreateWebsiteItem from './CreateWebsiteItem';

const ChartGrid = styled.div`
    display:grid;
    margin-top: 20px;    
    grid-gap: 15px;
    grid-template-columns: 1fr 2fr;
`


export default function(){
    return <Page name='home'>
        <div>
            <h1>Welcome to the WebString</h1>
            <h6>Enter a website Url to retrieve HTML string from.</h6>
            <ChartGrid>
                <CreateWebsiteItem/>
                <WebsiteList/>
            </ChartGrid>
        </div>
    </Page>
    
}