import axios from 'axios';

async function convertWebsite(site) {
    let website ={};
    console.log( site['website'])
    await axios.post(`https://localhost:5014/api/Conversion/ConvertUrl`,
    {
        website: site.website
    }
    ).then(response => {        
        website = response;
    }).catch(e => {
        console.log('Error in website conversion', e);
    });    
    return website.data;
}

export {
    convertWebsite
}